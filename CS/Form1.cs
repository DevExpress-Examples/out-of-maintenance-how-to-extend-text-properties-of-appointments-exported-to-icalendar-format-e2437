using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
#region #usings
using DevExpress.XtraScheduler.iCalendar;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.iCalendar.Components;
#endregion #usings

namespace iCalendarDemo {
    public partial class Form1 : Form {
        private const string RecipientsDataColumn = "RecipientsData";

        public Form1() {
            InitializeComponent();
            schedulerControl1.Start = new DateTime(2010, 09, 20);

            //this.eventsTableAdapter.Adapter.RowUpdated += new OleDbRowUpdatedEventHandler(Adapter_RowUpdated);
        }

        void Adapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e) {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert) {
                int id = 0;
                using (OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY", this.eventsTableAdapter.Connection)) {
                    id = (int)cmd.ExecuteScalar();
                }
                e.Row["UID"] = id;
            }
        }
        
        private void schedulerStorage1_AppointmentsInserted(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e) {
            this.eventsTableAdapter.Update(this.dsEvents);
            this.dsEvents.AcceptChanges();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'dsEvents.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.dsEvents.Events);

        }

        private void schedulerControl1_InitAppointmentDisplayText(object sender, DevExpress.XtraScheduler.AppointmentDisplayTextEventArgs e) {
            string attendees = "\r\nRequired Attendees: " + Convert.ToString(e.Appointment.CustomFields[RecipientsDataColumn]); 
            e.Description = e.Description + attendees;
        }
        private void schedulerControl1_InitNewAppointment(object sender, AppointmentEventArgs e) {
            e.Appointment.CustomFields[RecipientsDataColumn] = "test@company.com";
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e) {
            using (CustomAppointmentEditForm f = new CustomAppointmentEditForm(schedulerControl1, e.Appointment)) {
                f.LookAndFeel.ParentLookAndFeel = schedulerControl1.LookAndFeel.ParentLookAndFeel;
                e.DialogResult = f.ShowDialog();
                e.Handled = true;
            }

        }

        private void btnExport_Click(object sender, EventArgs e) {
            using(SaveFileDialog fileDialog = new SaveFileDialog()) {
                fileDialog.Filter = "iCalendar files (*.ics)|*.ics";
                fileDialog.FilterIndex = 1;
                fileDialog.FileName = "SchedulerEvents";

                if (fileDialog.ShowDialog() != DialogResult.OK)
                    return;
                try {
                    using (Stream stream = fileDialog.OpenFile())
                        ExportAppointments(stream);
                } catch {
                    MessageBox.Show("Error: could not export appointments");
                }
            }
        }
        #region #export
        void ExportAppointments(Stream stream) {
            if (stream == null)
                return;
            iCalendarExporter exporter = new iCalendarExporter(schedulerStorage1);
            exporter.AppointmentExporting += 
                new AppointmentExportingEventHandler(exporter_AppointmentExporting);
            exporter.Export(stream);
        }
        void exporter_AppointmentExporting(object sender, AppointmentExportingEventArgs e) {
            string s = Convert.ToString(e.Appointment.CustomFields[RecipientsDataColumn]);
            string[] attendees = s.Split(';');

            iCalendarAppointmentExportingEventArgs args = e as iCalendarAppointmentExportingEventArgs;
            AddEventAttendees(args.VEvent, attendees);
        }
        private void AddEventAttendees(VEvent ev, string[] addresses) {
            int count = addresses.Length;
            for (int i = 0; i < count; i++)
                AddEventAttendee(ev, addresses[i]);
        }
        private void AddEventAttendee(VEvent ev, string address) {
            TextProperty p = new TextProperty("ATTENDEE", 
                String.Format("mailto:{0}", address));
            p.AddParameter("CN", address);
            p.AddParameter("RSVP", "TRUE");
            ev.CustomProperties.Add(p);
        }
        #endregion #export
    }
}
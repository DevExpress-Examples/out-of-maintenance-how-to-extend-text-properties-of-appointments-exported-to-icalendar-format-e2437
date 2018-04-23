using System;
using System.Windows.Forms;

using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.UI;
using DevExpress.XtraScheduler.Native;
// ...

namespace iCalendarDemo {
	public partial class CustomAppointmentEditForm : DevExpress.XtraEditors.XtraForm {
		SchedulerControl control;
		Appointment apt;
		int suspendUpdateCount;
		private DevExpress.XtraEditors.CheckEdit checkAllDay;
		// Note that the MyAppointmentFormController class is inherited from
		// the AppointmentFormController one to add custom properties.
		// See its declaration at the end of this file.
		MyAppointmentFormController controller;

		public CustomAppointmentEditForm(SchedulerControl control, Appointment apt) {
			this.controller = new MyAppointmentFormController(control, apt);
			this.apt = apt;
			this.control = control;
			//
			// Required for Windows Form Designer support
			//
			SuspendUpdate();
			InitializeComponent();
			ResumeUpdate();

			UpdateForm();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		protected AppointmentStorage Appointments { get { return control.Storage.Appointments; } }
        protected internal bool IsNewAppointment { get { return controller != null ? controller.IsNewAppointment : true; } }
		protected bool IsUpdateSuspended { get { return suspendUpdateCount > 0; } }

		protected void SuspendUpdate() {
			suspendUpdateCount++;
		}
		protected void ResumeUpdate() {
			if (suspendUpdateCount > 0)
				suspendUpdateCount--;
		}
		private void btnOK_Click(object sender, System.EventArgs e) {
			// Required to check appointment's conflicts.
			if (!controller.IsConflictResolved())
				return;

			controller.Subject = txSubject.Text;
			controller.SetLabel(edtLabel.Label);
			controller.AllDay = this.checkAllDay.Checked;
			controller.Start = this.dtStart.DateTime.Date + this.timeStart.Time.TimeOfDay;
			controller.End = this.dtEnd.DateTime.Date + this.timeEnd.Time.TimeOfDay;
			controller.Attendees = txAttendees.Text;
			

			// Save all changes made to the appointment edited in a form.
			controller.ApplyChanges();
		}

		void UpdateForm() {
			SuspendUpdate();
			try {
				txSubject.Text = controller.Subject;
                tbLocation.Text = controller.Location;
                tbDescription.Text = controller.Description;
				edtLabel.Label = Appointments.Labels[controller.LabelId];

				dtStart.DateTime = controller.Start.Date;
				dtEnd.DateTime = controller.End.Date;

				timeStart.Time = DateTime.MinValue.AddTicks(controller.Start.TimeOfDay.Ticks);
				timeEnd.Time = DateTime.MinValue.AddTicks(controller.End.TimeOfDay.Ticks);
				checkAllDay.Checked = controller.AllDay;

				edtLabel.Storage = control.Storage;
				txAttendees.Text = controller.Attendees;

                bool remindersEnabled = control.RemindersEnabled;
                chkReminder.Enabled = remindersEnabled;
                chkReminder.Visible = remindersEnabled;
                chkReminder.Checked = controller.HasReminder;

                UpdateReminderCombo();
                UpdateFormCaption();
			}
			finally {
				ResumeUpdate();
			}
			UpdateIntervalControls();
		}
        protected internal virtual void UpdateFormCaption() {
            this.Text = SchedulerUtils.FormatAppointmentFormCaption(controller.AllDay, controller.Subject, false);
        }
        protected internal virtual void UpdateReminderCombo() {
            if (controller.HasReminder)
                cbReminder.Duration = controller.ReminderTimeBeforeStart;
            else
                cbReminder.Text = String.Empty;

            bool remindersEnabled = control.RemindersEnabled;
            cbReminder.Enabled = remindersEnabled && controller.HasReminder;
            cbReminder.Visible = remindersEnabled;
        }


		private void dtStart_EditValueChanged(object sender, System.EventArgs e) {
			if (!IsUpdateSuspended)
				controller.Start = dtStart.DateTime.Date + timeStart.Time.TimeOfDay;
			UpdateIntervalControls();
		}
		protected virtual void UpdateIntervalControls() {
			if (IsUpdateSuspended)
				return;

			SuspendUpdate();
			try {
				dtStart.EditValue = controller.Start.Date;
				dtEnd.EditValue = controller.End.Date;
				timeStart.EditValue = controller.Start.TimeOfDay;
				timeEnd.EditValue = controller.End.TimeOfDay;

                Appointment editedAptCopy = controller.EditedAppointmentCopy;
                bool showControls = IsNewAppointment || editedAptCopy.Type != AppointmentType.Pattern;
                dtStart.Enabled = showControls;
                dtEnd.Enabled = showControls;
                bool enableTime = showControls && !controller.AllDay;
                timeStart.Visible = enableTime;
                timeStart.Enabled = enableTime;
                timeEnd.Visible = enableTime;
                timeEnd.Enabled = enableTime;
                checkAllDay.Enabled = showControls;
			}
			finally {
				ResumeUpdate();
			}
		}
		private void timeStart_EditValueChanged(object sender, System.EventArgs e) {
			if (!IsUpdateSuspended)
				controller.Start = dtStart.DateTime.Date + timeStart.Time.TimeOfDay;
			UpdateIntervalControls();
		}
		private void timeEnd_EditValueChanged(object sender, System.EventArgs e) {
			if (IsUpdateSuspended) return;
			if (IsIntervalValid())
				controller.End = dtEnd.DateTime + timeEnd.Time.TimeOfDay;
			else
				timeEnd.EditValue = controller.End.TimeOfDay;
		}
		private void dtEnd_EditValueChanged(object sender, System.EventArgs e) {
			if (IsUpdateSuspended) return;
			if (IsIntervalValid())
				controller.End = dtEnd.DateTime + timeEnd.Time.TimeOfDay;
			else
				dtEnd.EditValue = controller.End.Date;
		}
		bool IsIntervalValid() {
			DateTime start = dtStart.DateTime + timeStart.Time.TimeOfDay;
			DateTime end = dtEnd.DateTime + timeEnd.Time.TimeOfDay;
			return end >= start;
		}

		private void checkAllDay_CheckedChanged(object sender, System.EventArgs e) {
			controller.AllDay = this.checkAllDay.Checked;
			UpdateIntervalControls();
		}

        private void tbDescription_EditValueChanged(object sender, EventArgs e) {
            if (IsUpdateSuspended) return;
            controller.Description = tbDescription.Text;
        }

        private void tbLocation_EditValueChanged(object sender, EventArgs e) {
            if (IsUpdateSuspended) return;
            controller.Location = tbLocation.Text;
        }
        private void txAttendees_EditValueChanged(object sender, EventArgs e) {
            controller.Attendees = txAttendees.Text;
        }

        private void chkReminder_CheckedChanged(object sender, EventArgs e) {
            controller.HasReminder = chkReminder.Checked;
            UpdateReminderCombo();
        }

	}
	public class MyAppointmentFormController : AppointmentFormController {
        public string Attendees { get { return Convert.ToString(EditedAppointmentCopy.CustomFields["RecipientsData"]); } set { EditedAppointmentCopy.CustomFields["RecipientsData"] = value; } }
        string SourceAttendees { get { return Convert.ToString(SourceAppointment.CustomFields["RecipientsData"]); } set { SourceAppointment.CustomFields["RecipientsData"] = value; } }

		public MyAppointmentFormController(SchedulerControl control, Appointment apt)
			: base(control, apt) {
		}

		public override bool IsAppointmentChanged() {
			if (base.IsAppointmentChanged())
				return true;
			return SourceAttendees != Attendees;
				
		}
		protected override void ApplyCustomFieldsValues() {
			SourceAttendees = Attendees;
		}
	}
}

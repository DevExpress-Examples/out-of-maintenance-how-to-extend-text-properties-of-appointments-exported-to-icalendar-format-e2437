Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.IO
#Region "#usings"
Imports DevExpress.XtraScheduler.iCalendar
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.iCalendar.Components
#End Region ' #usings

Namespace iCalendarDemo
    Partial Public Class Form1
        Inherits Form

        Private Const RecipientsDataColumn As String = "RecipientsData"

        Public Sub New()
            InitializeComponent()
            schedulerControl1.Start = New Date(2010, 09, 20)

            'this.eventsTableAdapter.Adapter.RowUpdated += new OleDbRowUpdatedEventHandler(Adapter_RowUpdated);
        End Sub

        Private Sub Adapter_RowUpdated(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)
            If e.Status = UpdateStatus.Continue AndAlso e.StatementType = StatementType.Insert Then
                Dim id As Integer = 0
                Using cmd As New OleDbCommand("SELECT @@IDENTITY", Me.eventsTableAdapter.Connection)
                    id = DirectCast(cmd.ExecuteScalar(), Integer)
                End Using
                e.Row("UID") = id
            End If
        End Sub

        Private Sub schedulerStorage1_AppointmentsInserted(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectsEventArgs) Handles schedulerStorage1.AppointmentsChanged, schedulerStorage1.AppointmentsInserted, schedulerStorage1.AppointmentsDeleted
            Me.eventsTableAdapter.Update(Me.dsEvents)
            Me.dsEvents.AcceptChanges()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' TODO: This line of code loads data into the 'dsEvents.Events' table. You can move, or remove it, as needed.
            Me.eventsTableAdapter.Fill(Me.dsEvents.Events)

        End Sub

        Private Sub schedulerControl1_InitAppointmentDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentDisplayTextEventArgs) Handles schedulerControl1.InitAppointmentDisplayText
            Dim attendees As String = ControlChars.CrLf & "Required Attendees: " & Convert.ToString(e.Appointment.CustomFields(RecipientsDataColumn))
            e.Description = e.Description & attendees
        End Sub
        Private Sub schedulerControl1_InitNewAppointment(ByVal sender As Object, ByVal e As AppointmentEventArgs) Handles schedulerControl1.InitNewAppointment
            e.Appointment.CustomFields(RecipientsDataColumn) = "test@company.com"
        End Sub

        Private Sub schedulerControl1_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As AppointmentFormEventArgs) Handles schedulerControl1.EditAppointmentFormShowing
            Using f As New CustomAppointmentEditForm(schedulerControl1, e.Appointment)
                f.LookAndFeel.ParentLookAndFeel = schedulerControl1.LookAndFeel.ParentLookAndFeel
                e.DialogResult = f.ShowDialog()
                e.Handled = True
            End Using

        End Sub

        Private Sub btnExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExport.Click
            Using fileDialog As New SaveFileDialog()
                fileDialog.Filter = "iCalendar files (*.ics)|*.ics"
                fileDialog.FilterIndex = 1
                fileDialog.FileName = "SchedulerEvents"

                If fileDialog.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
                    Return
                End If
                Try
                    Using stream As Stream = fileDialog.OpenFile()
                        ExportAppointments(stream)
                    End Using
                Catch
                    MessageBox.Show("Error: could not export appointments")
                End Try
            End Using
        End Sub
        #Region "#export"
        Private Sub ExportAppointments(ByVal stream As Stream)
            If stream Is Nothing Then
                Return
            End If
            Dim exporter As New iCalendarExporter(schedulerStorage1)
            AddHandler exporter.AppointmentExporting, AddressOf exporter_AppointmentExporting
            exporter.Export(stream)
        End Sub
        Private Sub exporter_AppointmentExporting(ByVal sender As Object, ByVal e As AppointmentExportingEventArgs)
            Dim s As String = Convert.ToString(e.Appointment.CustomFields(RecipientsDataColumn))
            Dim attendees() As String = s.Split(";"c)

            Dim args As iCalendarAppointmentExportingEventArgs = TryCast(e, iCalendarAppointmentExportingEventArgs)
            AddEventAttendees(args.VEvent, attendees)
        End Sub
        Private Sub AddEventAttendees(ByVal ev As VEvent, ByVal addresses() As String)
            Dim count As Integer = addresses.Length
            For i As Integer = 0 To count - 1
                AddEventAttendee(ev, addresses(i))
            Next i
        End Sub
        Private Sub AddEventAttendee(ByVal ev As VEvent, ByVal address As String)
            Dim p As New TextProperty("ATTENDEE", String.Format("mailto:{0}", address))
            p.AddParameter("CN", address)
            p.AddParameter("RSVP", "TRUE")
            ev.CustomProperties.Add(p)
        End Sub
        #End Region ' #export
    End Class
End Namespace
Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.UI
Imports DevExpress.XtraScheduler.Native
' ...

Namespace iCalendarDemo
	Partial Public Class CustomAppointmentEditForm
		Inherits DevExpress.XtraEditors.XtraForm
		Private control As SchedulerControl
		Private apt As Appointment
		Private suspendUpdateCount As Integer
		Private WithEvents checkAllDay As DevExpress.XtraEditors.CheckEdit
		' Note that the MyAppointmentFormController class is inherited from
		' the AppointmentFormController one to add custom properties.
		' See its declaration at the end of this file.
		Private controller As MyAppointmentFormController

		Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
			Me.controller = New MyAppointmentFormController(control, apt)
			Me.apt = apt
			Me.control = control
			'
			' Required for Windows Form Designer support
			'
			SuspendUpdate()
			InitializeComponent()
			ResumeUpdate()

			UpdateForm()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Protected ReadOnly Property Appointments() As AppointmentStorage
			Get
				Return control.Storage.Appointments
			End Get
		End Property
		Protected Friend ReadOnly Property IsNewAppointment() As Boolean
			Get
				If controller IsNot Nothing Then
					Return controller.IsNewAppointment
				Else
					Return True
				End If
			End Get
		End Property
		Protected ReadOnly Property IsUpdateSuspended() As Boolean
			Get
				Return suspendUpdateCount > 0
			End Get
		End Property

		Protected Sub SuspendUpdate()
			suspendUpdateCount += 1
		End Sub
		Protected Sub ResumeUpdate()
			If suspendUpdateCount > 0 Then
				suspendUpdateCount -= 1
			End If
		End Sub
		Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
			' Required to check appointment's conflicts.
			If (Not controller.IsConflictResolved()) Then
				Return
			End If

			controller.Subject = txSubject.Text
			controller.SetLabel(edtLabel.Label)
			controller.AllDay = Me.checkAllDay.Checked
			controller.Start = Me.dtStart.DateTime.Date + Me.timeStart.Time.TimeOfDay
			controller.End = Me.dtEnd.DateTime.Date + Me.timeEnd.Time.TimeOfDay
			controller.Attendees = txAttendees.Text


			' Save all changes made to the appointment edited in a form.
			controller.ApplyChanges()
		End Sub

		Private Sub UpdateForm()
			SuspendUpdate()
			Try
				txSubject.Text = controller.Subject
				tbLocation.Text = controller.Location
				tbDescription.Text = controller.Description
				edtLabel.Label = Appointments.Labels(controller.LabelId)

				dtStart.DateTime = controller.Start.Date
				dtEnd.DateTime = controller.End.Date

				timeStart.Time = DateTime.MinValue.AddTicks(controller.Start.TimeOfDay.Ticks)
				timeEnd.Time = DateTime.MinValue.AddTicks(controller.End.TimeOfDay.Ticks)
				checkAllDay.Checked = controller.AllDay

				edtLabel.Storage = control.Storage
				txAttendees.Text = controller.Attendees

				Dim remindersEnabled As Boolean = control.RemindersEnabled
				chkReminder.Enabled = remindersEnabled
				chkReminder.Visible = remindersEnabled
				chkReminder.Checked = controller.HasReminder

				UpdateReminderCombo()
				UpdateFormCaption()
			Finally
				ResumeUpdate()
			End Try
			UpdateIntervalControls()
		End Sub
		Protected Friend Overridable Sub UpdateFormCaption()
			Me.Text = SchedulerUtils.FormatAppointmentFormCaption(controller.AllDay, controller.Subject, False)
		End Sub
		Protected Friend Overridable Sub UpdateReminderCombo()
			If controller.HasReminder Then
				cbReminder.Duration = controller.ReminderTimeBeforeStart
			Else
				cbReminder.Text = String.Empty
			End If

			Dim remindersEnabled As Boolean = control.RemindersEnabled
			cbReminder.Enabled = remindersEnabled AndAlso controller.HasReminder
			cbReminder.Visible = remindersEnabled
		End Sub


		Private Sub dtStart_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtStart.EditValueChanged
			If (Not IsUpdateSuspended) Then
				controller.Start = dtStart.DateTime.Date + timeStart.Time.TimeOfDay
			End If
			UpdateIntervalControls()
		End Sub
		Protected Overridable Sub UpdateIntervalControls()
			If IsUpdateSuspended Then
				Return
			End If

			SuspendUpdate()
			Try
				dtStart.EditValue = controller.Start.Date
				dtEnd.EditValue = controller.End.Date
				timeStart.EditValue = controller.Start.TimeOfDay
				timeEnd.EditValue = controller.End.TimeOfDay

				Dim editedAptCopy As Appointment = controller.EditedAppointmentCopy
				Dim showControls As Boolean = IsNewAppointment OrElse editedAptCopy.Type <> AppointmentType.Pattern
				dtStart.Enabled = showControls
				dtEnd.Enabled = showControls
				Dim enableTime As Boolean = showControls AndAlso Not controller.AllDay
				timeStart.Visible = enableTime
				timeStart.Enabled = enableTime
				timeEnd.Visible = enableTime
				timeEnd.Enabled = enableTime
				checkAllDay.Enabled = showControls
			Finally
				ResumeUpdate()
			End Try
		End Sub
		Private Sub timeStart_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles timeStart.EditValueChanged
			If (Not IsUpdateSuspended) Then
				controller.Start = dtStart.DateTime.Date + timeStart.Time.TimeOfDay
			End If
			UpdateIntervalControls()
		End Sub
		Private Sub timeEnd_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles timeEnd.EditValueChanged
			If IsUpdateSuspended Then
				Return
			End If
			If IsIntervalValid() Then
				controller.End = dtEnd.DateTime + timeEnd.Time.TimeOfDay
			Else
				timeEnd.EditValue = controller.End.TimeOfDay
			End If
		End Sub
		Private Sub dtEnd_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtEnd.EditValueChanged
			If IsUpdateSuspended Then
				Return
			End If
			If IsIntervalValid() Then
				controller.End = dtEnd.DateTime + timeEnd.Time.TimeOfDay
			Else
				dtEnd.EditValue = controller.End.Date
			End If
		End Sub
		Private Function IsIntervalValid() As Boolean
			Dim start As DateTime = dtStart.DateTime + timeStart.Time.TimeOfDay
			Dim [end] As DateTime = dtEnd.DateTime + timeEnd.Time.TimeOfDay
			Return [end] >= start
		End Function

		Private Sub checkAllDay_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkAllDay.CheckedChanged
			controller.AllDay = Me.checkAllDay.Checked
			UpdateIntervalControls()
		End Sub

		Private Sub tbDescription_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbDescription.EditValueChanged
			If IsUpdateSuspended Then
				Return
			End If
			controller.Description = tbDescription.Text
		End Sub

		Private Sub tbLocation_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbLocation.EditValueChanged
			If IsUpdateSuspended Then
				Return
			End If
			controller.Location = tbLocation.Text
		End Sub
		Private Sub txAttendees_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txAttendees.EditValueChanged
			controller.Attendees = txAttendees.Text
		End Sub

		Private Sub chkReminder_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkReminder.CheckedChanged
			controller.HasReminder = chkReminder.Checked
			UpdateReminderCombo()
		End Sub

	End Class
	Public Class MyAppointmentFormController
		Inherits AppointmentFormController
		Public Property Attendees() As String
			Get
				Return Convert.ToString(EditedAppointmentCopy.CustomFields("RecipientsData"))
			End Get
			Set(ByVal value As String)
				EditedAppointmentCopy.CustomFields("RecipientsData") = value
			End Set
		End Property
		Private Property SourceAttendees() As String
			Get
				Return Convert.ToString(SourceAppointment.CustomFields("RecipientsData"))
			End Get
			Set(ByVal value As String)
				SourceAppointment.CustomFields("RecipientsData") = value
			End Set
		End Property

		Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
			MyBase.New(control, apt)
		End Sub

		Public Overrides Function IsAppointmentChanged() As Boolean
			If MyBase.IsAppointmentChanged() Then
				Return True
			End If
			Return SourceAttendees <> Attendees

		End Function
		Protected Overrides Sub ApplyCustomFieldsValues()
			SourceAttendees = Attendees
		End Sub
	End Class
End Namespace

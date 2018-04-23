Imports Microsoft.VisualBasic
Imports System
Namespace iCalendarDemo
	Partial Public Class CustomAppointmentEditForm
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
			Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
			Me.lblSubject = New System.Windows.Forms.Label()
			Me.txSubject = New DevExpress.XtraEditors.TextEdit()
			Me.lblStart = New System.Windows.Forms.Label()
			Me.lblEnd = New System.Windows.Forms.Label()
			Me.lbAttendees = New System.Windows.Forms.Label()
			Me.txAttendees = New DevExpress.XtraEditors.TextEdit()
			Me.dtStart = New DevExpress.XtraEditors.DateEdit()
			Me.dtEnd = New DevExpress.XtraEditors.DateEdit()
			Me.timeStart = New DevExpress.XtraEditors.TimeEdit()
			Me.timeEnd = New DevExpress.XtraEditors.TimeEdit()
			Me.checkAllDay = New DevExpress.XtraEditors.CheckEdit()
			Me.lblLocation = New DevExpress.XtraEditors.LabelControl()
			Me.tbLocation = New DevExpress.XtraEditors.TextEdit()
			Me.edtLabel = New DevExpress.XtraScheduler.UI.AppointmentLabelEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.tbDescription = New DevExpress.XtraEditors.MemoEdit()
			Me.cbReminder = New DevExpress.XtraScheduler.UI.DurationEdit()
			Me.chkReminder = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.txSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txAttendees.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dtStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dtStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dtEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.timeStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.timeEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkAllDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnOK
			' 
			Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.btnOK.Location = New System.Drawing.Point(118, 286)
			Me.btnOK.Name = "btnOK"
			Me.btnOK.Size = New System.Drawing.Size(110, 24)
			Me.btnOK.TabIndex = 12
			Me.btnOK.Text = "OK"
'			Me.btnOK.Click += New System.EventHandler(Me.btnOK_Click);
			' 
			' btnCancel
			' 
			Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.btnCancel.Location = New System.Drawing.Point(234, 286)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New System.Drawing.Size(110, 24)
			Me.btnCancel.TabIndex = 13
			Me.btnCancel.Text = "Cancel"
			' 
			' lblSubject
			' 
			Me.lblSubject.Location = New System.Drawing.Point(6, 11)
			Me.lblSubject.Name = "lblSubject"
			Me.lblSubject.Size = New System.Drawing.Size(48, 18)
			Me.lblSubject.TabIndex = 4
			Me.lblSubject.Text = "Subject:"
			' 
			' txSubject
			' 
			Me.txSubject.EditValue = ""
			Me.txSubject.Location = New System.Drawing.Point(71, 8)
			Me.txSubject.Name = "txSubject"
			Me.txSubject.Size = New System.Drawing.Size(383, 20)
			Me.txSubject.TabIndex = 0
			' 
			' lblStart
			' 
			Me.lblStart.Location = New System.Drawing.Point(6, 78)
			Me.lblStart.Name = "lblStart"
			Me.lblStart.Size = New System.Drawing.Size(36, 18)
			Me.lblStart.TabIndex = 12
			Me.lblStart.Text = "Start:"
			' 
			' lblEnd
			' 
			Me.lblEnd.Location = New System.Drawing.Point(6, 104)
			Me.lblEnd.Name = "lblEnd"
			Me.lblEnd.Size = New System.Drawing.Size(48, 18)
			Me.lblEnd.TabIndex = 13
			Me.lblEnd.Text = "End:"
			' 
			' lbAttendees
			' 
			Me.lbAttendees.Location = New System.Drawing.Point(6, 175)
			Me.lbAttendees.Name = "lbAttendees"
			Me.lbAttendees.Size = New System.Drawing.Size(59, 19)
			Me.lbAttendees.TabIndex = 15
			Me.lbAttendees.Text = "Attendees:"
			' 
			' txAttendees
			' 
			Me.txAttendees.EditValue = ""
			Me.txAttendees.Location = New System.Drawing.Point(71, 174)
			Me.txAttendees.Name = "txAttendees"
			Me.txAttendees.Size = New System.Drawing.Size(383, 20)
			Me.txAttendees.TabIndex = 10
'			Me.txAttendees.EditValueChanged += New System.EventHandler(Me.txAttendees_EditValueChanged);
			' 
			' dtStart
			' 
			Me.dtStart.EditValue = New System.DateTime(2008, 6, 27, 0, 0, 0, 0)
			Me.dtStart.Location = New System.Drawing.Point(71, 76)
			Me.dtStart.Name = "dtStart"
			Me.dtStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dtStart.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dtStart.Size = New System.Drawing.Size(121, 20)
			Me.dtStart.TabIndex = 3
'			Me.dtStart.EditValueChanged += New System.EventHandler(Me.dtStart_EditValueChanged);
			' 
			' dtEnd
			' 
			Me.dtEnd.EditValue = New System.DateTime(2008, 6, 27, 0, 0, 0, 0)
			Me.dtEnd.Location = New System.Drawing.Point(71, 102)
			Me.dtEnd.Name = "dtEnd"
			Me.dtEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dtEnd.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dtEnd.Size = New System.Drawing.Size(121, 20)
			Me.dtEnd.TabIndex = 6
'			Me.dtEnd.EditValueChanged += New System.EventHandler(Me.dtEnd_EditValueChanged);
			' 
			' timeStart
			' 
			Me.timeStart.EditValue = New System.DateTime(2006, 3, 28, 0, 0, 0, 0)
			Me.timeStart.Location = New System.Drawing.Point(198, 76)
			Me.timeStart.Name = "timeStart"
			Me.timeStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.timeStart.Size = New System.Drawing.Size(93, 20)
			Me.timeStart.TabIndex = 4
'			Me.timeStart.EditValueChanged += New System.EventHandler(Me.timeStart_EditValueChanged);
			' 
			' timeEnd
			' 
			Me.timeEnd.EditValue = New System.DateTime(2006, 3, 28, 0, 0, 0, 0)
			Me.timeEnd.Location = New System.Drawing.Point(198, 102)
			Me.timeEnd.Name = "timeEnd"
			Me.timeEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.timeEnd.Size = New System.Drawing.Size(93, 20)
			Me.timeEnd.TabIndex = 7
'			Me.timeEnd.EditValueChanged += New System.EventHandler(Me.timeEnd_EditValueChanged);
			' 
			' checkAllDay
			' 
			Me.checkAllDay.Location = New System.Drawing.Point(297, 77)
			Me.checkAllDay.Name = "checkAllDay"
			Me.checkAllDay.Properties.Caption = "All day event"
			Me.checkAllDay.Size = New System.Drawing.Size(88, 19)
			Me.checkAllDay.TabIndex = 5
'			Me.checkAllDay.CheckedChanged += New System.EventHandler(Me.checkAllDay_CheckedChanged);
			' 
			' lblLocation
			' 
			Me.lblLocation.AccessibleName = "Location:"
			Me.lblLocation.Location = New System.Drawing.Point(9, 37)
			Me.lblLocation.Name = "lblLocation"
			Me.lblLocation.Size = New System.Drawing.Size(44, 13)
			Me.lblLocation.TabIndex = 16
			Me.lblLocation.Text = "&Location:"
			' 
			' tbLocation
			' 
			Me.tbLocation.EditValue = ""
			Me.tbLocation.Location = New System.Drawing.Point(71, 34)
			Me.tbLocation.Name = "tbLocation"
			Me.tbLocation.Properties.AccessibleName = "Location"
			Me.tbLocation.Size = New System.Drawing.Size(221, 20)
			Me.tbLocation.TabIndex = 1
'			Me.tbLocation.EditValueChanged += New System.EventHandler(Me.tbLocation_EditValueChanged);
			' 
			' edtLabel
			' 
			Me.edtLabel.Location = New System.Drawing.Point(334, 34)
			Me.edtLabel.Name = "edtLabel"
			Me.edtLabel.Properties.AccessibleName = "Label"
			Me.edtLabel.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
			Me.edtLabel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.edtLabel.Size = New System.Drawing.Size(120, 20)
			Me.edtLabel.TabIndex = 2
			' 
			' labelControl1
			' 
			Me.labelControl1.AccessibleName = "Label:"
			Me.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.labelControl1.Location = New System.Drawing.Point(299, 37)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(29, 13)
			Me.labelControl1.TabIndex = 18
			Me.labelControl1.Text = "La&bel:"
			' 
			' tbDescription
			' 
			Me.tbDescription.EditValue = ""
			Me.tbDescription.Location = New System.Drawing.Point(15, 211)
			Me.tbDescription.Name = "tbDescription"
			Me.tbDescription.Properties.AccessibleName = "Message"
			Me.tbDescription.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Client
			Me.tbDescription.Size = New System.Drawing.Size(439, 57)
			Me.tbDescription.TabIndex = 11
'			Me.tbDescription.EditValueChanged += New System.EventHandler(Me.tbDescription_EditValueChanged);
			' 
			' cbReminder
			' 
			Me.cbReminder.EditValue = ""
			Me.cbReminder.Location = New System.Drawing.Point(375, 136)
			Me.cbReminder.Name = "cbReminder"
			Me.cbReminder.Properties.AccessibleName = "Reminder"
			Me.cbReminder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbReminder.Size = New System.Drawing.Size(79, 20)
			Me.cbReminder.TabIndex = 9
			' 
			' chkReminder
			' 
			Me.chkReminder.Location = New System.Drawing.Point(297, 137)
			Me.chkReminder.Name = "chkReminder"
			Me.chkReminder.Properties.Caption = "&Reminder"
			Me.chkReminder.Size = New System.Drawing.Size(72, 19)
			Me.chkReminder.TabIndex = 8
'			Me.chkReminder.CheckedChanged += New System.EventHandler(Me.chkReminder_CheckedChanged);
			' 
			' MyAppointmentEditForm
			' 
			Me.AcceptButton = Me.btnOK
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New System.Drawing.Size(463, 322)
			Me.Controls.Add(Me.cbReminder)
			Me.Controls.Add(Me.chkReminder)
			Me.Controls.Add(Me.tbDescription)
			Me.Controls.Add(Me.edtLabel)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.lblLocation)
			Me.Controls.Add(Me.tbLocation)
			Me.Controls.Add(Me.checkAllDay)
			Me.Controls.Add(Me.timeEnd)
			Me.Controls.Add(Me.timeStart)
			Me.Controls.Add(Me.dtEnd)
			Me.Controls.Add(Me.dtStart)
			Me.Controls.Add(Me.txAttendees)
			Me.Controls.Add(Me.lbAttendees)
			Me.Controls.Add(Me.lblEnd)
			Me.Controls.Add(Me.lblStart)
			Me.Controls.Add(Me.txSubject)
			Me.Controls.Add(Me.lblSubject)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.btnOK)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "MyAppointmentEditForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Edit Appointment"
			CType(Me.txSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txAttendees.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dtStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dtStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dtEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.timeStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.timeEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkAllDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		Private WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
		Private btnCancel As DevExpress.XtraEditors.SimpleButton
		Private txSubject As DevExpress.XtraEditors.TextEdit
		Private lblSubject As System.Windows.Forms.Label
		Private lblStart As System.Windows.Forms.Label
		Private lblEnd As System.Windows.Forms.Label
		Private lbAttendees As System.Windows.Forms.Label
		Private WithEvents txAttendees As DevExpress.XtraEditors.TextEdit
		Private WithEvents dtStart As DevExpress.XtraEditors.DateEdit
		Private WithEvents dtEnd As DevExpress.XtraEditors.DateEdit
		Private WithEvents timeStart As DevExpress.XtraEditors.TimeEdit
		Private WithEvents timeEnd As DevExpress.XtraEditors.TimeEdit
		Protected lblLocation As DevExpress.XtraEditors.LabelControl
		Protected WithEvents tbLocation As DevExpress.XtraEditors.TextEdit
		Protected edtLabel As DevExpress.XtraScheduler.UI.AppointmentLabelEdit
		Protected labelControl1 As DevExpress.XtraEditors.LabelControl
		Protected WithEvents tbDescription As DevExpress.XtraEditors.MemoEdit
		Protected cbReminder As DevExpress.XtraScheduler.UI.DurationEdit
		Protected WithEvents chkReminder As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace

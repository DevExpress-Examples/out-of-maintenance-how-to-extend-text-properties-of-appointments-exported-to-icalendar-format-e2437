Imports Microsoft.VisualBasic
Imports System
Namespace iCalendarDemo
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.bsEvents = New System.Windows.Forms.BindingSource(Me.components)
			Me.dsEvents = New iCalendarDemo.CalendarEventsDataSet()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
			Me.eventsTableAdapter = New iCalendarDemo.CalendarEventsDataSetTableAdapters.EventsTableAdapter()
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bsEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl1.Location = New System.Drawing.Point(0, 36)
			Me.schedulerControl1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.Size = New System.Drawing.Size(719, 386)
			Me.schedulerControl1.Start = New System.DateTime(2010, 8, 20, 0, 0, 0, 0)
			Me.schedulerControl1.Storage = Me.schedulerStorage1
			Me.schedulerControl1.TabIndex = 0
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.Views.DayView.ShowWorkTimeOnly = True
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
'			Me.schedulerControl1.InitAppointmentDisplayText += New DevExpress.XtraScheduler.AppointmentDisplayTextEventHandler(Me.schedulerControl1_InitAppointmentDisplayText);
'			Me.schedulerControl1.InitNewAppointment += New DevExpress.XtraScheduler.AppointmentEventHandler(Me.schedulerControl1_InitNewAppointment);
'			Me.schedulerControl1.EditAppointmentFormShowing += New DevExpress.XtraScheduler.AppointmentFormEventHandler(Me.schedulerControl1_EditAppointmentFormShowing);
			' 
			' schedulerStorage1
			' 
			Me.schedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("RecipientsData", "RecipientsData", DevExpress.XtraScheduler.FieldValueType.String))
			Me.schedulerStorage1.Appointments.DataSource = Me.bsEvents
			Me.schedulerStorage1.Appointments.Mappings.Description = "Body"
			Me.schedulerStorage1.Appointments.Mappings.End = "End"
			Me.schedulerStorage1.Appointments.Mappings.Label = "MeetingStatus"
			Me.schedulerStorage1.Appointments.Mappings.Location = "Location"
			Me.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderData"
			Me.schedulerStorage1.Appointments.Mappings.Start = "Start"
			Me.schedulerStorage1.Appointments.Mappings.Subject = "Subject"
'			Me.schedulerStorage1.AppointmentsChanged += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.schedulerStorage1_AppointmentsInserted);
'			Me.schedulerStorage1.AppointmentsInserted += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.schedulerStorage1_AppointmentsInserted);
'			Me.schedulerStorage1.AppointmentsDeleted += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.schedulerStorage1_AppointmentsInserted);
			' 
			' bsEvents
			' 
			Me.bsEvents.DataMember = "Events"
			Me.bsEvents.DataSource = Me.dsEvents
			' 
			' dsEvents
			' 
			Me.dsEvents.DataSetName = "CalendarEventsDataSet"
			Me.dsEvents.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.btnExport)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(719, 36)
			Me.panelControl1.TabIndex = 1
			' 
			' btnExport
			' 
			Me.btnExport.Location = New System.Drawing.Point(5, 7)
			Me.btnExport.Name = "btnExport"
			Me.btnExport.Size = New System.Drawing.Size(109, 23)
			Me.btnExport.TabIndex = 0
			Me.btnExport.Text = "Export"
'			Me.btnExport.Click += New System.EventHandler(Me.btnExport_Click);
			' 
			' eventsTableAdapter
			' 
			Me.eventsTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(719, 422)
			Me.Controls.Add(Me.schedulerControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Export to iCalendar"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bsEvents, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsEvents, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
		Private WithEvents schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private bsEvents As System.Windows.Forms.BindingSource
		Private dsEvents As CalendarEventsDataSet
		Private eventsTableAdapter As iCalendarDemo.CalendarEventsDataSetTableAdapters.EventsTableAdapter
		Private WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace


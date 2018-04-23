namespace iCalendarDemo {
	partial class CustomAppointmentEditForm {
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txSubject = new DevExpress.XtraEditors.TextEdit();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lbAttendees = new System.Windows.Forms.Label();
            this.txAttendees = new DevExpress.XtraEditors.TextEdit();
            this.dtStart = new DevExpress.XtraEditors.DateEdit();
            this.dtEnd = new DevExpress.XtraEditors.DateEdit();
            this.timeStart = new DevExpress.XtraEditors.TimeEdit();
            this.timeEnd = new DevExpress.XtraEditors.TimeEdit();
            this.checkAllDay = new DevExpress.XtraEditors.CheckEdit();
            this.lblLocation = new DevExpress.XtraEditors.LabelControl();
            this.tbLocation = new DevExpress.XtraEditors.TextEdit();
            this.edtLabel = new DevExpress.XtraScheduler.UI.AppointmentLabelEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbDescription = new DevExpress.XtraEditors.MemoEdit();
            this.cbReminder = new DevExpress.XtraScheduler.UI.DurationEdit();
            this.chkReminder = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txAttendees.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAllDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(118, 286);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(110, 24);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(234, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 24);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            // 
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(6, 11);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(48, 18);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Subject:";
            // 
            // txSubject
            // 
            this.txSubject.EditValue = "";
            this.txSubject.Location = new System.Drawing.Point(71, 8);
            this.txSubject.Name = "txSubject";
            this.txSubject.Size = new System.Drawing.Size(383, 20);
            this.txSubject.TabIndex = 0;
            // 
            // lblStart
            // 
            this.lblStart.Location = new System.Drawing.Point(6, 78);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(36, 18);
            this.lblStart.TabIndex = 12;
            this.lblStart.Text = "Start:";
            // 
            // lblEnd
            // 
            this.lblEnd.Location = new System.Drawing.Point(6, 104);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(48, 18);
            this.lblEnd.TabIndex = 13;
            this.lblEnd.Text = "End:";
            // 
            // lbAttendees
            // 
            this.lbAttendees.Location = new System.Drawing.Point(6, 175);
            this.lbAttendees.Name = "lbAttendees";
            this.lbAttendees.Size = new System.Drawing.Size(59, 19);
            this.lbAttendees.TabIndex = 15;
            this.lbAttendees.Text = "Attendees:";
            // 
            // txAttendees
            // 
            this.txAttendees.EditValue = "";
            this.txAttendees.Location = new System.Drawing.Point(71, 174);
            this.txAttendees.Name = "txAttendees";
            this.txAttendees.Size = new System.Drawing.Size(383, 20);
            this.txAttendees.TabIndex = 10;
            this.txAttendees.EditValueChanged += new System.EventHandler(this.txAttendees_EditValueChanged);
            // 
            // dtStart
            // 
            this.dtStart.EditValue = new System.DateTime(2008, 6, 27, 0, 0, 0, 0);
            this.dtStart.Location = new System.Drawing.Point(71, 76);
            this.dtStart.Name = "dtStart";
            this.dtStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtStart.Size = new System.Drawing.Size(121, 20);
            this.dtStart.TabIndex = 3;
            this.dtStart.EditValueChanged += new System.EventHandler(this.dtStart_EditValueChanged);
            // 
            // dtEnd
            // 
            this.dtEnd.EditValue = new System.DateTime(2008, 6, 27, 0, 0, 0, 0);
            this.dtEnd.Location = new System.Drawing.Point(71, 102);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtEnd.Size = new System.Drawing.Size(121, 20);
            this.dtEnd.TabIndex = 6;
            this.dtEnd.EditValueChanged += new System.EventHandler(this.dtEnd_EditValueChanged);
            // 
            // timeStart
            // 
            this.timeStart.EditValue = new System.DateTime(2006, 3, 28, 0, 0, 0, 0);
            this.timeStart.Location = new System.Drawing.Point(198, 76);
            this.timeStart.Name = "timeStart";
            this.timeStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.timeStart.Size = new System.Drawing.Size(93, 20);
            this.timeStart.TabIndex = 4;
            this.timeStart.EditValueChanged += new System.EventHandler(this.timeStart_EditValueChanged);
            // 
            // timeEnd
            // 
            this.timeEnd.EditValue = new System.DateTime(2006, 3, 28, 0, 0, 0, 0);
            this.timeEnd.Location = new System.Drawing.Point(198, 102);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.timeEnd.Size = new System.Drawing.Size(93, 20);
            this.timeEnd.TabIndex = 7;
            this.timeEnd.EditValueChanged += new System.EventHandler(this.timeEnd_EditValueChanged);
            // 
            // checkAllDay
            // 
            this.checkAllDay.Location = new System.Drawing.Point(297, 77);
            this.checkAllDay.Name = "checkAllDay";
            this.checkAllDay.Properties.Caption = "All day event";
            this.checkAllDay.Size = new System.Drawing.Size(88, 19);
            this.checkAllDay.TabIndex = 5;
            this.checkAllDay.CheckedChanged += new System.EventHandler(this.checkAllDay_CheckedChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.AccessibleName = "Location:";
            this.lblLocation.Location = new System.Drawing.Point(9, 37);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(44, 13);
            this.lblLocation.TabIndex = 16;
            this.lblLocation.Text = "&Location:";
            // 
            // tbLocation
            // 
            this.tbLocation.EditValue = "";
            this.tbLocation.Location = new System.Drawing.Point(71, 34);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Properties.AccessibleName = "Location";
            this.tbLocation.Size = new System.Drawing.Size(221, 20);
            this.tbLocation.TabIndex = 1;
            this.tbLocation.EditValueChanged += new System.EventHandler(this.tbLocation_EditValueChanged);
            // 
            // edtLabel
            // 
            this.edtLabel.Location = new System.Drawing.Point(334, 34);
            this.edtLabel.Name = "edtLabel";
            this.edtLabel.Properties.AccessibleName = "Label";
            this.edtLabel.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.edtLabel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtLabel.Size = new System.Drawing.Size(120, 20);
            this.edtLabel.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.AccessibleName = "Label:";
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Location = new System.Drawing.Point(299, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "La&bel:";
            // 
            // tbDescription
            // 
            this.tbDescription.EditValue = "";
            this.tbDescription.Location = new System.Drawing.Point(15, 211);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Properties.AccessibleName = "Message";
            this.tbDescription.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.tbDescription.Size = new System.Drawing.Size(439, 57);
            this.tbDescription.TabIndex = 11;
            this.tbDescription.EditValueChanged += new System.EventHandler(this.tbDescription_EditValueChanged);
            // 
            // cbReminder
            // 
            this.cbReminder.EditValue = "";
            this.cbReminder.Location = new System.Drawing.Point(375, 136);
            this.cbReminder.Name = "cbReminder";
            this.cbReminder.Properties.AccessibleName = "Reminder";
            this.cbReminder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbReminder.Size = new System.Drawing.Size(79, 20);
            this.cbReminder.TabIndex = 9;
            // 
            // chkReminder
            // 
            this.chkReminder.Location = new System.Drawing.Point(297, 137);
            this.chkReminder.Name = "chkReminder";
            this.chkReminder.Properties.Caption = "&Reminder";
            this.chkReminder.Size = new System.Drawing.Size(72, 19);
            this.chkReminder.TabIndex = 8;
            this.chkReminder.CheckedChanged += new System.EventHandler(this.chkReminder_CheckedChanged);
            // 
            // MyAppointmentEditForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(463, 322);
            this.Controls.Add(this.cbReminder);
            this.Controls.Add(this.chkReminder);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.edtLabel);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.checkAllDay);
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.timeStart);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.txAttendees);
            this.Controls.Add(this.lbAttendees);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.txSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyAppointmentEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.txSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txAttendees.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAllDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private DevExpress.XtraEditors.SimpleButton btnOK;
		private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txSubject;
        private System.Windows.Forms.Label lblSubject;
		private System.Windows.Forms.Label lblStart;
		private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lbAttendees;
        private DevExpress.XtraEditors.TextEdit txAttendees;
		private DevExpress.XtraEditors.DateEdit dtStart;
		private DevExpress.XtraEditors.DateEdit dtEnd;
		private DevExpress.XtraEditors.TimeEdit timeStart;
		private DevExpress.XtraEditors.TimeEdit timeEnd;
        protected DevExpress.XtraEditors.LabelControl lblLocation;
        protected DevExpress.XtraEditors.TextEdit tbLocation;
        protected DevExpress.XtraScheduler.UI.AppointmentLabelEdit edtLabel;
        protected DevExpress.XtraEditors.LabelControl labelControl1;
        protected DevExpress.XtraEditors.MemoEdit tbDescription;
        protected DevExpress.XtraScheduler.UI.DurationEdit cbReminder;
        protected DevExpress.XtraEditors.CheckEdit chkReminder;
	}
}

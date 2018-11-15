<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to extend text properties of appointments exported to iCalendar format


<p>This example demonstrates how you can export e-mail addresses stored in a database to the <strong>ics</strong> file as required attendees. </p><p>The XtraScheduler originally does not support meeting requests with attendees. To accomplish this task, use the CustomFields mechanism to bind e-mail data to scheduler appointments. To control the export process that is performed via the <strong>Export</strong> method of the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraScheduleriCalendariCalendarExportertopic"> iCalendarExporter</a> class, handle its <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraSchedulerExchangeAppointmentExporter_AppointmentExportingtopic">AppointmentExporting</a> event. Within the event handler, you can modify VEvent object's properties and extend it with custom text properties. <br />
To create a new text property -<strong> ATTENDEE</strong> in this case - create an object of the <strong>DevExpress.XtraScheduler.iCalendar.Components.TextProperty</strong> type, specify required parameters (<strong>CN</strong> and <strong>RSVP</strong>) and add this property to the<strong> DevExpress.XtraScheduler.iCalendar.Components.iCalendarPropertyCollection</strong> of custom properties. This collection is accessible via the <strong>CustomProperties</strong> property of the current <strong>VEvent</strong> object.</p><p>The sample project contains an MS Access (mdb) database and a custom AppointmentForm so you can edit custom fields containing e-mail data. </p><p>To see the result, open the saved <strong>ics</strong> file in MS Outlook, double-click the imported appointment  and see addresses of the attendees displayed in the Meeting form.</p>

<br/>



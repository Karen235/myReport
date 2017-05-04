Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports

Partial Class _Default
    Inherits System.Web.UI.Page

    Dim conn As String = ConfigurationManager.ConnectionStrings("HRConnectionString").ToString

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        If IsPostBack = False Then
            '
            'Dim cn As New SqlConnection(conn)
            'Dim dap As New SqlDataAdapter("select wid,'' id,c_name,e_name,email from person", cn)
            'Dim ds As New dsRpt
            'dap.Fill(ds.Person)


            Dim ds As DataSet = DirectCast(Type.InvokeMember(methodName, BindingFlags.InvokeMethod Or BindingFlags.Instance Or BindingFlags.[Public], Nothing, obj, If(Parameter Is Nothing, Nothing, (If((isJsonParam), New String() {Parameter}, Parameter.Split(","c))))), DataSet)

            CrystalReportViewer1.EnableDatabaseLogonPrompt = False
            CrystalReportSource1.ReportDocument.SetDataSource(ds)
            'Response.Write(ds.Person.Rows.Count)
            'Dim Report As New ReportDocument
            'Report.Load(Server.MapPath("CrystalReport1.rpt"))
            'Report.SetDataSource(ds)
            ''Report.SetDatabaseLogon("sa", "admin")
            'CrystalReportViewer1.ReportSource = Report
            'CrystalReportViewer1.DataBind()


            'Dim rd As New ReportDocument()
            'rd.SetDatabaseLogon("sa", "admin")
            'rd.SetDataSource(ds.Tables(0))
            'CrystalReportViewer1.ReportSource = rd
            'CrystalReportViewer1.DataBind()
        End If
    End Sub
End Class

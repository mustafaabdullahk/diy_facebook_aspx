using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Ara : System.Web.UI.Page
{
    OleDbConnection bag = new OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/vt.mdb"));

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["ara"]!=null)
        {
            
        OleDbCommand kmt = new OleDbCommand("select * from uyeler where adi like '%" +Request["ara"]+ "%'", bag);
        OleDbDataAdapter aramak = new OleDbDataAdapter(kmt);
        DataTable dt = new DataTable();
        aramak.Fill(dt);
        DataList3.DataSource = dt;
        DataList3.DataBind(); 
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
            
	}

 
}

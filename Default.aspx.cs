using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page
{

    OleDbConnection bag = new OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/vt.mdb"));

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UyeId"] == null)
        {
            Session.Abandon();
            Response.Redirect("giris.aspx");
            Page.Dispose();
        }
        if (Request["Kisi"]!=null)
        {
            bag.Close();
            bag.Open();
            OleDbCommand ekle = new OleDbCommand("insert into arkadas(uyegonderen,uyealan) values('" + Session["UyeID"] + "','" + Request["Kisi"] + "')",bag);
            ekle.ExecuteNonQuery();
        }
    }
}
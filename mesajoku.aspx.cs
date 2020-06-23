using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class mesajoku : System.Web.UI.Page
{
    OleDbConnection con = new OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/vt.mdb"));
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["mesajid"];
        string kdurum = "1";
        string kdurumres = "resim/okundu.png";
        OleDbDataAdapter da = new OleDbDataAdapter("select * from mesajlar", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        DetailsView1.DataSource = dt;
        DetailsView1.DataBind();
        OleDbCommand com = new OleDbCommand("UPDATE mesajlar SET durum='" + kdurum + "', durumres='" + kdurumres + "' where mesajid=@mesajid", con);
        com.Parameters.Add("@mesajid", OleDbType.Variant).Value = id;
        con.Open();
        com.ExecuteNonQuery();
        com.Dispose();
        con.Close();
    }
    protected void okuiste_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
}

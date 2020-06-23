using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class mesaj : System.Web.UI.Page
{
    OleDbConnection bag = new OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/vt.mdb"));
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UyeId"] == null)
        {
            Response.Redirect("giris.aspx");
            Page.Dispose();
        }

        OleDbCommand d = new OleDbCommand("select * from uyeler where uyeID="+Session["UyeID"]+"",bag);
        OleDbDataReader oku;
        bag.Open();
        oku = d.ExecuteReader();
        while (oku.Read())
        {
            isim0.Text = oku[1].ToString();
            isim1.Text=oku[2].ToString();
        }
        OleDbDataAdapter doldur = new OleDbDataAdapter("SELECT * from mesajlar where kime="+Session["UyeID"], bag);
        DataTable dt = new DataTable();
        doldur.Fill(dt);
        DetailsView1.DataSource = dt;
        DetailsView1.DataBind();
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bag.Close();
        bag.Open();
        OleDbCommand com = new OleDbCommand("insert into mesajlar(kimden,mesaj,tarih,durum,kime) values (@kimden,@mesaj,@tarih,@durum,kime)",bag);
        com.Parameters.Add("@kimden",Session["UyeID"]);
        com.Parameters.Add("@mesaj", pmesaj.Text);
        com.Parameters.Add("@tarih", System.DateTime.Now.ToShortDateString());
        com.Parameters.Add("@durum", 0);
        com.Parameters.Add("@kime", Request["alici"]);
        com.ExecuteNonQuery();
        com.Dispose();
        bag.Close();
        onay.Text = "Mesaj yollandı";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
       
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
        Panel1.Visible = false;
        OleDbDataAdapter d1 = new OleDbDataAdapter("select * from mesajlar", bag);
        DataTable dt = new DataTable();
        d1.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}
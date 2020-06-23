using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class giris : System.Web.UI.Page
{
    OleDbConnection bag = new OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/vt.mdb"));

    public void bos()
    {
        txtad.Text = "";
        txtsoyad.Text = "";
        txtsifre.Text = "";
        txteposta.Text = "";
        
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["UyeId"] = null;
    }
    protected void butkaydol_Click(object sender, EventArgs e)
    { bag.Close();
        bag.Open();
        OleDbCommand kaydet = new OleDbCommand("insert into uyeler(adi,soyadi,eposta,sifre) values(@1,@2,@3,@4)", bag);
        if (txtad.Text=="" || txtsoyad.Text=="" || txteposta.Text=="" || txtsifre.Text=="")
        {
            Label1.Text = "Tüm Alanları Doldurun";
            Label1.Visible = true;
            Image1.ImageUrl = "cancel.png";
            Image1.Visible = true;
            
        }
        else
        { 
       
        kaydet.Parameters.Add("@1", txtad.Text);
        kaydet.Parameters.Add("@2", txtsoyad.Text);
        kaydet.Parameters.Add("@3", txteposta.Text);
        kaydet.Parameters.Add("@4", txtsifre.Text );
        kaydet.ExecuteNonQuery();
        }
        bag.Close();
    }
    protected void butgir_Click(object sender, EventArgs e)
    {
        bag.Close();
        bag.Open();
        OleDbCommand sorgu = new OleDbCommand("select * from uyeler Where adi=@Kullanici and sifre=@Sifre", bag);
        sorgu.Parameters.Add("@Kullanici", txtgirad.Text);
        sorgu.Parameters.Add("@Sifre", txtgirsifre.Text);
        OleDbDataReader dr = sorgu.ExecuteReader();
        while (dr.Read())
        {
            if (dr[1].ToString() == txtgirad.Text && dr[5].ToString() == txtgirsifre.Text)
            {
                Session["UyeId"] = dr[0];
                Response.Redirect("~/default.aspx");
            }


           
        }

        bag.Close();
    }
}
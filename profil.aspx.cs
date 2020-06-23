using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class profil : System.Web.UI.Page
{
    OleDbConnection bag = new OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/vt.mdb"));

    public void güncelle()
    {

        OleDbCommand guncelle = new OleDbCommand("update uyeler set adi=@1,soyadi=@2,eposta=@3,foto=@4,sifre=@5 where uyeID=@6", bag);

        OleDbDataReader dr;
        bag.Close();
        bag.Open();
        guncelle.Parameters.Add("@1", txtadi.Text);
        guncelle.Parameters.Add("@2", txtsoyadi.Text);
        guncelle.Parameters.Add("@3", txteposta.Text);
        
        if (FileUpload1.FileName != "")
        {
            guncelle.Parameters.Add("@4", FileUpload1.FileName);
            FileUpload1.SaveAs(Server.MapPath("images/" + FileUpload1.FileName));
        }
        guncelle.Parameters.Add("@5", txtsifre.Text);
        guncelle.Parameters.Add("@6", Session["UyeID"]);
        dr = guncelle.ExecuteReader();
        dr.Read();
        while (dr.Read())
        {
            txtadi.Text = dr[1].ToString();
            txtsoyadi.Text = dr[2].ToString();
            txteposta.Text = dr[3].ToString();
            txtsifre.Text = dr[5].ToString();



        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UyeId"] == null)
        {
            Response.Redirect("giris.aspx");
            Page.Dispose();
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //bag.Close();
        //bag.Open();
        //OleDbCommand guncellead = new OleDbCommand("update uyeler set adi=@1 where uyeID=@2");
        //guncellead.Parameters.Add("@1", TextBox2.Text);
        //guncellead.Parameters.Add("@2", Session["UyeId"]);
        //guncellead.ExecuteNonQuery();
        //bag.Close();

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        //bag.Close();
        //bag.Open();
        //OleDbCommand guncellead = new OleDbCommand("update uyeler set soyadi=@1 where uyeID=@2");
        //guncellead.Parameters.Add("@1", TextBox3.Text);
        //guncellead.Parameters.Add("@2", Session["UyeId"]);
        //guncellead.ExecuteNonQuery();
        //bag.Close();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        //    bag.Close();
        //    bag.Open();
        //    OleDbCommand guncellead = new OleDbCommand("update uyeler set eposta=@1 where uyeID=@2");
        //    guncellead.Parameters.Add("@1", TextBox4.Text);
        //    guncellead.Parameters.Add("@2", Session["UyeId"]);
        //    guncellead.ExecuteNonQuery();
        //    bag.Close();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        //bag.Close();
        //bag.Open();
        //OleDbCommand guncellead = new OleDbCommand("update uyeler set foto=@1 where uyeID=@2");
        //guncellead.Parameters.Add("@1", FileUpload1.FileName);
        //FileUpload1.SaveAs(Server.MapPath("images/" + FileUpload1.FileName));
        //guncellead.Parameters.Add("@2", Session["UyeId"]);
        //guncellead.ExecuteNonQuery();
        //bag.Close();
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        //bag.Close();
        //bag.Open();
        //OleDbCommand guncellead = new OleDbCommand("update uyeler set sifre=@1 where uyeID=@2");
        //guncellead.Parameters.Add("@1", TextBox6.Text);
        //guncellead.Parameters.Add("@2", Session["UyeId"]);
        //guncellead.ExecuteNonQuery();
        //bag.Close();
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        güncelle();

    }
}

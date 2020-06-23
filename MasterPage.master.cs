using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class MasterPage : System.Web.UI.MasterPage
{
    OleDbConnection bag = new OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/vt.mdb"));
   OleDbDataReader dr;
    public void datadoldur()
    {
         bag.Close();
        bag.Open();
        OleDbDataAdapter adptr = new OleDbDataAdapter("select * from uyeler where UyeID <> " + Session["UyeID"] + " and uyeID in(select uyegonderen from arkadas where uyealan="+Session["UyeID"]+") or uyeID in (select uyealan from arkadas where uyegonderen="+Session["UyeID"]+")", bag);
        DataTable dt = new DataTable();
        adptr.Fill(dt);
        DataList1.DataSource = dt;
        DataList1.DataBind();
       
        Session["uyealan"] = "6";
    }
    public void datadoldur2()
    {
        OleDbDataAdapter adptr2 = new OleDbDataAdapter("select * from uyeler where uyeID in (select uyealan from arkadas where uyegonderen=" + Session["UyeID"] + " and arkadas.onay=true) or uyeID in (select uyegonderen from arkadas where uyealan=" + Session["UyeID"]+" and arkadas.onay=true) and uyeID in(select uyegonderen from arkadas where uyegonderen<>" + Session["UyeID"] +") and  uyeID<>"+Session["UyeID"], bag);
        DataTable dt2 = new DataTable();
        adptr2.Fill(dt2);
        DataList2.DataSource = dt2;
        DataList2.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        bag.Close();
        bag.Open();
        OleDbCommand doldur = new OleDbCommand("select * from uyeler where uyeID=@1", bag);
        doldur.Parameters.Add("@1", Session["UyeID"]);
        OleDbDataReader oku;
        oku = doldur.ExecuteReader();

        while (oku.Read())
        {
            Image1.ImageUrl = "images/" + oku[4].ToString();
            Label1.Text = oku[1].ToString();
            Label2.Text = oku[2].ToString();
            Label7.Text = oku[3].ToString();

        }
        datadoldur();
        datadoldur2();
        
    }
    protected void LinkButton1_Click(object sender, EventArgs e)

    {
        bag.Close();
        bag.Open();
        
         OleDbCommand arkekle = new OleDbCommand("insert into arkadas (uyegonderen,uyealan,onay,adi,soyadi,foto) values (@1,@2,false,@3,@4,@5)", bag);
       

        arkekle.Parameters.Add("@1",Session["UyeID"]);
        arkekle.Parameters.Add("@2", Session["uyealan"]);
        
        
        arkekle.ExecuteNonQuery();
        bag.Close();
        
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Session["UyeID"] = null;
        if (Session["UyeId"] == null)
        {
            Response.Redirect("giris.aspx");
            Page.Dispose();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/profil.aspx?uyeID=" + Session["UyeId"].ToString());
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/mesaj.aspx?");
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/default.aspx?uyeID=" + Session["UyeId"].ToString());
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/istek.aspx?uyeID=" + Session["UyeId"].ToString());
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Ara.aspx?ara=" + TextBox1.Text);
    }
}

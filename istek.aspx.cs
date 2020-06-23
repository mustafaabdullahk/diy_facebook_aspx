using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class istek : System.Web.UI.Page
{
    OleDbConnection bag = new OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/vt.mdb"));

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["istek"]!=null)
        {
            bag.Close();
            bag.Open();
            OleDbCommand onay = new OleDbCommand("update arkadas set onay=true where uyegonderen=" + Request["istek"], bag);
            onay.ExecuteNonQuery();
        }
        if (Session["UyeId"] == null)
        {
            Response.Redirect("giris.aspx");
        }

        OleDbDataAdapter doldur = new OleDbDataAdapter("SELECT arkadas.uyegonderen, arkadas.onay, uyeler.adi, uyeler.soyadi, uyeler.foto, uyeler.uyeID FROM arkadas INNER JOIN uyeler ON arkadas.uyegonderen = uyeler.uyeID WHERE (((arkadas.uyealan)="+Session["UyeID"]+") AND ((arkadas.onay)=False));", bag);
        DataTable dt = new DataTable();
        doldur.Fill(dt);
        DataList3.DataSource = dt;
        DataList3.DataBind();
    }
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{
    //    OleDbCommand arkol = new OleDbCommand("update arkadas set onay =@1", bag);
    //    bag.Close();
    //    bag.Open();
    //    arkol.Parameters.Add("@1", "true");
    //    bag.Close();
    //}
    protected void DataList3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
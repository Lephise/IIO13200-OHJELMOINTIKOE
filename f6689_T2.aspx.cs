using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class IIO13200_OHJELMOINTIKOE_f6689_T2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       string path = ConfigurationSettings.AppSettings["XmlPath"];

       DataSet ds = new DataSet();
       ds.ReadXml(MapPath(path));

       grid.DataSource = ds;
       grid.DataBind();

       XmlDocument xmldoc = new XmlDocument();
       xmldoc.Load(MapPath(path));

       XmlNodeList maara = xmldoc.SelectNodes("/tyontekijat/tyontekija[tyosuhde = 'vakituinen']/palkka");
       int palkat = 0;

       for (int i = 0; i < maara.Count; i++)
       {
           palkat = palkat + Convert.ToInt32(maara.Item(i).InnerText);
       }

       tiedot.Text = "Vakituisten määrä: " +  maara.Count.ToString() + ", Vakituisten yhteenlaskettu palkka: "+ palkat.ToString() ;


    }
}
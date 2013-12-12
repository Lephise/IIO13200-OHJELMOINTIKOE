using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class f6689_T3b : System.Web.UI.Page
{
    string path;
    XmlDocument xmldoc;

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            path = MapPath(ConfigurationSettings.AppSettings["Path"]);

        xmldoc = new XmlDocument();
        xmldoc.Load(path);

        XmlNodeList maara = xmldoc.SelectNodes("/tunnit/tunti");

        pvm.Text = DateTime.Today.ToString("dd/MM/yyyy");

        kirjmaar.Text = maara.Count.ToString();
        }
        catch (Exception ex)
        {
            
            throw;
        }

        

        

    }

    protected void submitti_Click(object sender, EventArgs e)
    {
       

        /*XmlDocument xmldoc = new XmlDocument();
        xmldoc.Load(path);
         * */

        XmlNode node = xmldoc.CreateNode(XmlNodeType.Element, "tunti", null);

        XmlNode child = xmldoc.CreateElement("koodaaja");
        child.InnerText = nimi.Text;
        node.AppendChild(child);

        child = xmldoc.CreateElement("pvm");
        child.InnerText = pvm.Text;
        node.AppendChild(child);

        child = xmldoc.CreateElement("koodausaika");
        child.InnerText = aika.Text;
        node.AppendChild(child);

        xmldoc.DocumentElement.AppendChild(node);

        xmldoc.Save(path);
    }


    protected void valittu_Click(object sender, EventArgs e)
    {

        
        
       // XmlNodeList koodari = xmldoc.SelectNodes("/tunnit/tunti[koodaaja = 'Seppo']");


       

        
    }
}
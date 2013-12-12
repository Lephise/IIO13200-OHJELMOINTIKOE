using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class f6689_T4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Ilmot"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(DISTINCT course), COUNT(DISTINCT asioid) FROM lasnaolot", connection);
            //SqlCommand cmdt = new SqlCommand("SELECT COUNT(DISTINCT asioid) FROM lasnaolot", connection);
            connection.Open();

            var kurssit = cmd.ExecuteReader();


            if (kurssit.Read())
            {
                testi.Text = "Eri opintojaksojen ilmoittautumisia:" + kurssit.GetValue(0).ToString() + " Eri Oppilaiden ilmoittautumisia : " + kurssit.GetValue(1).ToString();
                kurssit.Close();
            }

            connection.Close();

            cmd.CommandText = "SELECT DISTINCT course FROM lasnaolot";

            connection.Open();
            var op = cmd.ExecuteReader();

            while (op.Read())
            {
                ListItem item = new ListItem();
                item.Text = op.GetValue(0).ToString();
                opintojaksot.Items.Add(item);
            }


            connection.Close();


            cmd.CommandText = "SELECT DISTINCT firstname, lastname, asioid FROM lasnaolot ORDER BY lastname";

            connection.Open();
            op = cmd.ExecuteReader();

            while (op.Read())
            {
                ListItem item = new ListItem();
                item.Text = op.GetValue(0).ToString() + " " + op.GetValue(1).ToString();
                item.Value = op.GetValue(2).ToString();
                oppilaat.Items.Add(item);
            }


            connection.Close();
            }

            catch (Exception ex)
            {
                testi.Text = "Yhteys tietokantaan epäonnistui";
                
            }

            

        }
        

    }
    protected void kaikki_Click(object sender, EventArgs e)
    {
        //SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Ilmot"].ConnectionString);
        //SqlCommand cmd = new SqlCommand("SELECT DISTINCT firstname, DISTINCT lastname FROM lasnaolot", connection);
        //SqlCommand cmdt = new SqlCommand("SELECT COUNT(DISTINCT asioid) FROM lasnaolot", connection);
        
        //connection.Open();

        //var kurssit = cmd.ExecuteReader();
        try
        {
            SqlDataSource src = new SqlDataSource();
                    src.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Ilmot"].ConnectionString;
                    src.SelectCommand = "SELECT DISTINCT firstname, lastname FROM lasnaolot";

                    grid.DataSource = src;
                    grid.DataBind();
                    ilm.Text = "Haku onnistui";
        }
        catch (Exception ex)
        {
            ilm.Text = "Haku epäonnistui";
            
        }
        
       
        /*
        if (kurssit.Read())
        {
            testi.Text = "Eri opintojaksojen ilmoittautumisia:" + kurssit.GetValue(0).ToString() + " Eri Oppilaiden ilmoittautumisia : " + kurssit.GetValue(1).ToString();
            kurssit.Close();
        }




        connection.Close();
         * */
    }
    protected void kaikki_aak_Click(object sender, EventArgs e)
    {

        try
        {
            SqlDataSource src = new SqlDataSource();
                    src.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Ilmot"].ConnectionString;
                    src.SelectCommand = "SELECT DISTINCT firstname, lastname FROM lasnaolot ORDER BY lastname";

                    grid.DataSource = src;
                    grid.DataBind();
                    ilm.Text = "Haku onnistui";
        }
        catch (Exception ex)
        {
            ilm.Text = "Haku epäonnistui";
        }


        

    }
    protected void valittu_op_Click(object sender, EventArgs e)
    {

        try
        {
            SqlDataSource src = new SqlDataSource();
                    src.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Ilmot"].ConnectionString;
                    src.SelectCommand = "SELECT DISTINCT firstname, lastname FROM lasnaolot WHERE course = '"+opintojaksot.SelectedItem.Text+"'ORDER BY lastname";

                    grid.DataSource = src;
                    grid.DataBind();
                    ilm.Text = "Haku onnistui";
        }
        catch (Exception ex)
        {
            ilm.Text = "Haku epäonnistui";
           
        }


        
    }

    protected void valittu_oppilas_Click(object sender, EventArgs e)
    {

        try
        {
            SqlDataSource src = new SqlDataSource();
                    src.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Ilmot"].ConnectionString;
                    src.SelectCommand = "SELECT course, date FROM lasnaolot WHERE  asioid = '" + oppilaat.SelectedValue.ToString() + "'ORDER BY date";

                    grid.DataSource = src;
                    grid.DataBind();
                    ilm.Text = "Haku onnistui";
        }
        catch (Exception ex)
        {

            ilm.Text = "Haku epäonnistui";
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zadatak02 : System.Web.UI.Page
{
    List<CheckBox> checkBoxes;

    protected void Page_Load(object sender, EventArgs e)
    {
        LoadCheckbox();
    }

    private void LoadCheckbox()
    {
        checkBoxes = new List<CheckBox>();

        checkBoxes.Add(CheckBox1);
        checkBoxes.Add(CheckBox2);
        checkBoxes.Add(CheckBox3);
    }

    protected void btnConnect_Click(object sender, EventArgs e)
    {
        foreach (CheckBox cb in checkBoxes)
        {
            if (cb.Checked)
            {
                ConnectToDatabase(cb.Text);
            }
        }
    }

    private void ConnectToDatabase(string dbName)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

        con.StateChange += con_StateChange;

        try
        {
            lbStatus.Items.Add("OTVARANJE KONEKCIJE...");
            con.Open();
        }
        catch (SqlException ex)
        {
            lbStatus.Items.Add("SQL EXCEPTION: " + ex.Message);
        }
        catch (Exception ex)
        {
            lbStatus.Items.Add("EXCEPTION: " + ex.Message);
        }
        finally
        {
            lbStatus.Items.Add("ZATVARANJE KONEKCIJE...");
            con.Dispose();
        }
    }

    void con_StateChange(object sender, System.Data.StateChangeEventArgs e)
    {
        lbStatus.Items.Add("STATUS: " + e.CurrentState);
    }
}
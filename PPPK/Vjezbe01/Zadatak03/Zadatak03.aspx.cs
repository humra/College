using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zadatak03 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOpen_Click(object sender, EventArgs e)
    {
        string dbName = tbDBName.Text;

        SqlConnection con = new SqlConnection();
        con.StateChange += con_StateChange;
        con.InfoMessage += con_InfoMessage;

        try
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;
            con.Open();
        }
        catch (SqlException ex)
        {
            lbLog.Items.Add(ex.Message);
        }
        catch (Exception ex)
        {
            lbLog.Items.Add(ex.Message);
        }
        finally
        {
            con.Dispose();
        }

    }

    void con_InfoMessage(object sender, SqlInfoMessageEventArgs e)
    {
        lbLog.Items.Add("INFO: " + e.Message);
    }

    void con_StateChange(object sender, System.Data.StateChangeEventArgs e)
    {
        lbLog.Items.Add("STATE CHANGE: " + e.CurrentState);
    }
}
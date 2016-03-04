using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ishod04
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private String cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                napuniDrzave();
            }
        }

        private void napuniDrzave()
        {
            Database db = new SqlDatabase(cs);
            DbCommand cmd = db.GetSqlStringCommand("SELECT * FROM Drzava");

            using (IDataReader r = db.ExecuteReader(cmd))
            {
                while (r.Read())
                {
                    lbDrzave.Items.Add(new ListItem(r["Naziv"].ToString(), r["IdDrzava"].ToString()));
                }
            }
        }
    }
}
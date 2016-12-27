using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FarmaKravaWeb
{
    public partial class Farma : System.Web.UI.Page
    {
        FarmaKravaEntities db = new FarmaKravaEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                prikaziPasmine();

                gvKrave.AllowSorting = true;
            }
        }

        private void prikaziPasmine()
        {
            ddlPasmina.Items.Clear();

            ddlPasmina.DataSource = db.Pasminas.ToList();
            ddlPasmina.DataValueField = "ID";
            ddlPasmina.DataTextField = "Naziv";
            ddlPasmina.DataBind();

            ddlPasmina.SelectedIndex = 0;
            popuniGridView();
        }

        protected void ddlPasmina_SelectedIndexChanged(object sender, EventArgs e)
        {
            popuniGridView();
        }

        private void popuniGridView()
        {
            List<Krava> krave = (from k in db.Kravas where k.Pasmina.ToString().Equals(ddlPasmina.SelectedValue) select k).ToList();

            gvKrave.DataSource = krave;
            gvKrave.DataBind();
        }

        protected void dnevnaProizvodnjaShow(object sender, System.EventArgs e)
        {
            Button btnProizvodnja = (Button)sender;
            GridViewRow row = (GridViewRow)btnProizvodnja.NamingContainer;

            string id = row.Cells[0].Text;

            List<ProizvodnaMlijeka> proizvodnja = (from p in db.ProizvodnaMlijekas where p.KravaID.ToString().Equals(id) select p).ToList();

            gvDetalji.DataSource = proizvodnja;
            gvDetalji.DataBind();
            gvDetalji.Visible = true;
        }
    }
}
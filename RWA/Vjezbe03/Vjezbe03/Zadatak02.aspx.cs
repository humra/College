using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vjezbe03
{
    public partial class Zadatak02 : System.Web.UI.Page
    {
        public int brojBoja
        {
            get
            {
                if(Session["brojBoja"] == null)
                {
                    Session["brojBoja"] = 0;
                }
                return (int)Session["brojBoja"];
            }
            set
            {
                Session["brojBoja"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                kreirajPoljeZaUnosBoje(++brojBoja);
            }
            else
            {
                generirajSveKontrole();
                kreirajGumbZaPrikaz();
            }
        }

        private void kreirajGumbZaPrikaz()
        {
            Button btn = new Button();
            btn.Text = "Prikazi sve boje";
            btn.ID = "btnPrikaziSveBoje";
            btn.Click += btn_prikaziBojeClick;
            form1.Controls.AddAt(form1.Controls.Count - 1, btn);
        }

        private void btn_prikaziBojeClick(object sender, EventArgs e)
        {
            makniGumbZaPrikazBoja();

            DropDownList ddl = new DropDownList();
            ddl.ID = "Unesene boje";

            for(int i = 1; i <= brojBoja; i++)
            {
                ddl.Items.Add(((TextBox)form1.FindControl("txtBoja" + i)).Text.ToString());
            }
            form1.Controls.Add(ddl);
        }

        private void generirajSveKontrole()
        {
            for (int i = 1; i <= brojBoja; i++)
            {
                kreirajPoljeZaUnosBoje(i);
            }
        }

        private void kreirajPoljeZaUnosBoje(int broj)
        {
            Label lbl = new Label();
            lbl.Text = "Boja " + broj;
            form1.Controls.Add(lbl);

            TextBox txt = new TextBox();
            txt.ID = "txtBoja" + broj;
            form1.Controls.Add(txt);

            LinkButton lb = new LinkButton();
            lb.Text = "Dodaj jos boja";
            lb.Click += lb_Click;
            form1.Controls.Add(lb);

            form1.Controls.Add(new LiteralControl("<br/>"));
        }

        private void lb_Click(object sender, EventArgs e)
        {
            makniGumbZaPrikazBoja();

            kreirajPoljeZaUnosBoje(++brojBoja);
            form1.Controls.Add(new LiteralControl("<br/>"));

            kreirajGumbZaPrikaz();
        }

        private void makniGumbZaPrikazBoja()
        {
            Button btn = (Button) form1.FindControl("btnPrikaziSveBoje");
            form1.Controls.Remove(btn);
        }
    }
}
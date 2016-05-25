using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vjezbe03
{
    public partial class Zadatak01 : System.Web.UI.Page
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

        }

        protected override void OnPreInit(EventArgs e)
        {
            prikaziKontrole();
        }

        protected void btnPrikazi_Click(object sender, EventArgs e)
        {
            brojBoja = int.Parse(txtKolikoBoja.Text);
            prikaziKontrole();
        }

        private void prikaziKontrole()
        {
            if (brojBoja != 0)
            {
                for (int i = 1; i <= brojBoja; i++)
                {
                    prikaziPoljeZaUnosBoja(i);
                }
                prikaziGumbZaPrikazBoja();
            }
        }

        private void prikaziGumbZaPrikazBoja()
        {
            Button b = new Button();
            b.ID = "btnPrikaziUneseneBoje";
            b.Text = "Prikazi upisane boje";
            b.Click += btn_click;
            ph.Controls.Add(b);
        }

        private void btn_click(object sender, EventArgs e)
        {
            for(int i = 1; i <= brojBoja; i++)
            {
                TextBox txt = (TextBox)ph.FindControl("txtBoja" + i.ToString());
                blBoje.Items.Add(new ListItem(txt.Text));
            }
        }

        private void prikaziPoljeZaUnosBoja(int i)
        {
            Label lbl = new Label();
            lbl.Text = "Boja " + i.ToString();
            lbl.ID = "lblBoja" + i.ToString();
            ph.Controls.Add(lbl);

            TextBox txtBox = new TextBox();
            txtBox.ID = "txtBoja" + i.ToString();
            ph.Controls.Add(txtBox);

            ph.Controls.Add(new LiteralControl("<br/>"));
        }
    }
}
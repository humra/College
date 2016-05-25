using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vjezbe04
{
    public partial class Zadatak03 : System.Web.UI.Page
    {
        public int frames
        {
            get
            {
                if(Session["frames"] == null)
                {
                    Session["frames"] = 0;
                }
                return (int)Session["frames"];
            }
            set
            {
                Session["frames"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                prikaziPrvuKontrolu();
            }
        }

        private void prikaziPrvuKontrolu()
        {
            frames++;

            CtrlDefineButton ctrl = new CtrlDefineButton();

            
        }
    }
}
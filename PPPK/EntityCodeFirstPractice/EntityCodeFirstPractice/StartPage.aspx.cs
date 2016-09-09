using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityCodeFirstPractice
{
    public partial class StartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                napuniGuildove();
            }
        }

        private void napuniGuildove()
        {
            ddlGuilds.Items.Clear();

            using (var db = new GuildManagementContext())
            {
                var guilds = (from g in db.guilds select g).ToList();

                foreach(Guild g in guilds)
                {
                    ddlGuilds.Items.Add(new ListItem(g.name, g.guildID.ToString()));
                }
            }

            loadGuildMember();
        }

        protected void btnInsertGuild_Click(object sender, EventArgs e)
        {
            using (var db = new GuildManagementContext())
            {
                Guild tempGuild = new Guild();
                tempGuild.name = txtGuildName.Text;

                db.guilds.Add(tempGuild);
                db.SaveChanges();
                napuniGuildove();
            }
        }

        protected void btnInsertMember_Click(object sender, EventArgs e)
        {
            using (var db = new GuildManagementContext())
            {
                Member tempMember = new Member();
                tempMember.nickname = txtMemberNickname.Text;
                int temp;
                int.TryParse(txtMemberGuildId.Text, out temp);
                tempMember.guildID = temp;

                db.members.Add(tempMember);
                db.SaveChanges();

                loadGuildMember();
            }
        }

        private void loadGuildMember()
        {
            lbGuildMembers.Items.Clear();

            using (var db = new GuildManagementContext())
            {
                var members = (from m in db.members where m.guildID.ToString().Equals(ddlGuilds.SelectedValue) select m).ToList();

                foreach(Member m in members)
                {
                    lbGuildMembers.Items.Add(new ListItem(m.nickname));
                }
            }
        }

        protected void ddlGuilds_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGuildMember();
        }

        protected void btnDeleteMember_Click(object sender, EventArgs e)
        {
            using (var db = new GuildManagementContext())
            {
                var members = (from m in db.members where m.nickname.Equals(txtMemberNickname.Text) select m).ToList();

                foreach(Member m in members)
                {
                    db.members.Remove(m);
                    db.SaveChanges();
                }
            }

            loadGuildMember();
        }
    }
}
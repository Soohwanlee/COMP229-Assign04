using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JSONProject
{
    public partial class Model : System.Web.UI.Page
    {
        private Models.Model.ModelsData modelData;
        protected void Page_Load(object sender, EventArgs e)
        {
            string Name = Request.QueryString["name"];
            string Faction = Request.QueryString["faction"];

            try
            {
                if (!Name.Equals("") && !Faction.Equals(""))
                {
                    modelData = Global.models.FirstOrDefault(fModel => fModel.name == Name && fModel.faction == Faction);
                    DisplayData();
                }
                else
                {
                    Response.Redirect("LandingPage.aspx");
                }
            }

            catch
            {
                Response.Write("Error, please try again");
            }
        }

        private void DisplayData()
        {
            lblTitle.Text = modelData.name;
            lblName.Text = modelData.name;
            ImageId.ImageUrl = modelData.imageUrl;
            string base_ = Convert.ToString(modelData._base) + " mm";
            lblBase.Text = base_;
            lblFaction.Text = modelData.faction;
            lblRank.Text = Convert.ToString(modelData.rank);
            lblSize.Text = Convert.ToString(modelData.size);
            lblTraits.Text = String.Join(",", modelData.traits);
            lblDeployment.Text = modelData.deploymentZone;
            lblTypes.Text = String.Join(", ", modelData.types);
            lblDefence.Text = String.Join(", ", modelData.defenseChart);
            lblMobility.Text = Convert.ToString(modelData.mobility);
            lblWounds.Text = Convert.ToString(modelData.wounds);
            lblResiliance.Text = Convert.ToString(modelData.resiliance);
            ActionSpecial();
        }

        private void ActionSpecial()
        {
            string Name = Request.QueryString["name"];
            string Faction = Request.QueryString["faction"];
            modelData = Global.models.FirstOrDefault(fModel => fModel.name == Name && fModel.faction == Faction);
            repeater2.DataSource = modelData.actions;
            repeater2.DataBind();

            if(modelData.specialAbilities != null)
            {
                SpecialTitle.Visible = true;
                repeater3.Visible = true;
                repeater3.DataSource = modelData.specialAbilities;
                repeater3.DataBind();
            }
        }
    }
}
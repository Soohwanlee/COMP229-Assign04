using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;

namespace JSONProject
{
    public partial class Update : System.Web.UI.Page
    {
        private Models.Model.ModelsData updateModel = new Models.Model.ModelsData();
        private TextBox txtBoxName = new TextBox();
        private TextBox txtBoxFaction = new TextBox();
        private TextBox txtBoxRank = new TextBox();
        private TextBox txtBoxBase = new TextBox();
        private TextBox txtBoxDeployment = new TextBox();
        private TextBox txtBoxSize = new TextBox();
        private TextBox txtBoxTraits = new TextBox();
        private TextBox txtBoxTypes = new TextBox();
        private TextBox txtBoxDefence = new TextBox();
        private TextBox txtBoxMobility = new TextBox();
        private TextBox txtBoxResiliance = new TextBox();
        private TextBox txtBoxWounds = new TextBox();
        private TextBox txtBoxActName = new TextBox();
        private TextBox txtBoxActRange = new TextBox();
        private TextBox txtBoxActType = new TextBox();
        private TextBox txtBoxActRating = new TextBox();
        private TextBox txtBoxActDesc = new TextBox();
        private TextBox txtBoxSplName = new TextBox();
        private TextBox txtBoxSplDesc = new TextBox();

        protected void Page_Load(object sender, EventArgs e)
        {
            string Name = Request.QueryString["name"];
            string Faction = Request.QueryString["faction"];
            updateModel = Global.models.FirstOrDefault(fModel => fModel.name == Name && fModel.faction == Faction);

            try
            {
                if (!Name.Equals("") && !Faction.Equals(""))
                {
                    updateDetails();
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

        private void updateDetails()
        {
            ImageId.ImageUrl = updateModel.imageUrl;
            txtBoxName.Text = updateModel.name;
            plName.Controls.Add(txtBoxName);
            txtBoxFaction.Text = updateModel.faction;
            plFaction.Controls.Add(txtBoxFaction);
            txtBoxRank.Text = updateModel.rank.ToString();
            plRank.Controls.Add(txtBoxRank);
            txtBoxTypes.Text = updateModel.rank.ToString();
            plTypes.Controls.Add(txtBoxTypes);
            txtBoxMobility.Text = updateModel.rank.ToString();
            plMobility.Controls.Add(txtBoxMobility);
            txtBoxBase.Text = updateModel._base.ToString();
            plBase.Controls.Add(txtBoxBase);
            txtBoxSize.Text = updateModel.size.ToString();
            plSize.Controls.Add(txtBoxSize);
            txtBoxDeployment.Text = updateModel.deploymentZone;
            plDeployment.Controls.Add(txtBoxDeployment);
            txtBoxResiliance.Text = updateModel.resiliance.ToString();
            plResiliance.Controls.Add(txtBoxResiliance);
            txtBoxWounds.Text = updateModel.wounds.ToString();
            plWounds.Controls.Add(txtBoxWounds);
            txtBoxTraits.Text = updateModel.traits.ToString();
            plTraits.Controls.Add(txtBoxTraits);

                txtBoxActName.Text = updateModel.actions[0].name;
                plActName.Controls.Add(txtBoxActName);
                txtBoxActRange.Text = updateModel.actions[0].range;
                plActRange.Controls.Add(txtBoxActRange);
                txtBoxActRating.Text = updateModel.actions[0].rating.ToString();
                plActRating.Controls.Add(txtBoxActRating);
                txtBoxActType.Text = updateModel.actions[0].type;
                plActType.Controls.Add(txtBoxActType);
                txtBoxActDesc.Text = updateModel.actions[0].description;
                plActDesc.Controls.Add(txtBoxActDesc);

                txtBoxSplName.Text = updateModel.specialAbilities[0].name;
                plSplName.Controls.Add(txtBoxSplName);
                txtBoxSplDesc.Text = updateModel.specialAbilities[0].description;
                plSplDesc.Controls.Add(txtBoxSplDesc);


        }

        private void updateNewJSON()
        {
            using (StreamWriter streamWriter = File.CreateText(Server.MapPath("~/App_Data/Assign04New.json")))
            {
                streamWriter.WriteLine(JsonConvert.SerializeObject(updateModel));
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            updateModel.name = txtBoxName.Text;
            updateModel.faction = txtBoxFaction.Text;
            updateModel.rank = Convert.ToInt32(txtBoxRank.Text);
            updateModel._base = Convert.ToInt32(txtBoxBase.Text);
            updateModel.size = Convert.ToInt32(txtBoxSize.Text);
            updateModel.deploymentZone = txtBoxDeployment.Text;
            updateModel.mobility = Convert.ToInt32(txtBoxMobility.Text);
            updateModel.resiliance = Convert.ToInt32(txtBoxResiliance.Text);
            updateModel.wounds = Convert.ToInt32(txtBoxWounds.Text);
            updateModel.traits[0] = txtBoxTypes.Text;
            updateModel.types[0] = txtBoxTypes.Text;


            updateModel.actions[0].name = txtBoxActName.Text;
            updateModel.actions[0].range = txtBoxActRange.Text;
            updateModel.actions[0].rating = Convert.ToInt32(txtBoxActRating.Text);
            updateModel.actions[0].type = txtBoxActType.Text;
            updateModel.actions[0].description = txtBoxActDesc.Text;

            updateModel.specialAbilities[0].name = txtBoxSplName.Text;
            updateModel.specialAbilities[0].description = txtBoxSplDesc.Text;

            updateNewJSON();
            Response.Redirect("LandingPage.aspx");

        }
    }
}
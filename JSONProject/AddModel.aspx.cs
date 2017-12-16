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
    public partial class AddModel : System.Web.UI.Page
    {

        private Models.Model.ModelsData addModel = new Models.Model.ModelsData();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void updateNewJSON()
        {
            using (StreamWriter streamWriter = File.CreateText(Server.MapPath("~/App_Data/Assign04New.json")))
            {
                streamWriter.WriteLine(JsonConvert.SerializeObject(addModel));
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            addModel.name = txtBoxName.Text;
            addModel.faction = txtBoxFaction.Text;
            addModel.rank = Convert.ToInt32(txtBoxRank.Text);
            addModel._base = Convert.ToInt32(txtBoxBase.Text);
            addModel.size = Convert.ToInt32(txtBoxSize.Text);
            addModel.deploymentZone = txtBoxDeployment.Text;
            addModel.mobility = Convert.ToInt32(txtBoxMobility.Text);
            addModel.resiliance = Convert.ToInt32(txtBoxResiliance.Text);
            addModel.wounds = Convert.ToInt32(txtBoxWounds.Text);
            /*
            //addModel.traits[0] = txtBoxTraits.Text;
            //addModel.types[0] = txtBoxTypes.Text;
            //addModel.defenseChart[0] = txtBoxDefence.Text;


            addModel.actions[0].name = txtBoxActName.Text;
            addModel.actions[0].range = txtBoxActRange.Text;
            addModel.actions[0].rating = Convert.ToInt32(txtBoxActRating.Text);
            addModel.actions[0].type = txtBoxActType.Text;
            addModel.actions[0].description = txtBoxActDesc.Text;

            addModel.specialAbilities[0].name = txtBoxSplName.Text;
            addModel.specialAbilities[0].description = txtBoxSplDesc.Text;
            */
            updateNewJSON();

            string emailAddress = TextboxEmail.Text;
            string emailName = TextboxEmailName.Text;
            Global.SendEmail(emailAddress, emailName);
            Response.Redirect("LandingPage.aspx");

        }
    }
}
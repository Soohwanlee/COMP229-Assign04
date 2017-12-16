<%@ Page Title="Model Addition" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddModel.aspx.cs" Inherits="JSONProject.AddModel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <br />
    <br />
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <center><asp:Image ID="ImageId" Width="300px" runat="server" /></center><br />
                <h3 style="text-align: center"></h3>
            </div>

            <div class="col-md-8">
                <h2 style="text-align: center">Update Detail</h2>
                <asp:Label ID="lblId" runat="server" Text=""></asp:Label>
                <br />
                <strong>Name : </strong>
                <asp:Textbox ID="txtBoxName" runat="server"></asp:Textbox><br /><br />
                <strong>Faction : </strong>
                <asp:Textbox ID="txtBoxFaction" runat="server"></asp:Textbox><br /><br />
                <strong>Rank : </strong>
                <asp:Textbox ID="txtBoxRank" runat="server"></asp:Textbox><br /><br />
                <strong>Base : </strong>
                <asp:Textbox ID="txtBoxBase" runat="server"></asp:Textbox><br /><br />
                <strong>Deployment : </strong>
                <asp:Textbox ID="txtBoxDeployment" runat="server"></asp:Textbox><br /><br />
                <strong>Size : </strong>
                <asp:Textbox ID="txtBoxSize" runat="server"></asp:Textbox><br /><br />
                <strong>Traits : </strong>
                <asp:Textbox ID="txtBoxTraits" runat="server"></asp:Textbox><br /><br />
                <strong>Types : </strong>
                <asp:Textbox ID="txtBoxTypes" runat="server"></asp:Textbox><br /><br />
                <strong>DefenceChart : </strong>
                <asp:Textbox ID="txtBoxDefence" runat="server"></asp:Textbox><br /><br />
                <strong>Mobility : </strong>
                <asp:Textbox ID="txtBoxMobility" runat="server"></asp:Textbox><br /><br />
                <strong>Resiliance</strong>
                <asp:Textbox ID="txtBoxResiliance" runat="server"></asp:Textbox><br /><br />
                <strong>Wounds : </strong>
                <asp:Textbox ID="txtBoxWounds" runat="server"></asp:Textbox><br /><br />
                <hr />

                <h2 style="text-align: center">Actions</h2>
                    <strong>Name:</strong>
                    <asp:Textbox ID="txtBoxActName" runat="server"></asp:Textbox>
                    <br /><br />
                    <strong>Type:</strong>
                    <asp:Textbox ID="txtBoxActType" runat="server"></asp:Textbox>
                    <br /><br />
                    <strong>Rating(Number):</strong>
                    <asp:Textbox ID="txtBoxActRating" runat="server"></asp:Textbox>
                    <br /><br />
                    <strong>Range:</strong>
                    <asp:Textbox ID="txtBoxActRange" runat="server"></asp:Textbox>
                    <br /><br />
                    <strong>Description:</strong>
                    <asp:Textbox ID="txtBoxActDesc" runat="server"></asp:Textbox>
                    <br />
                    <br />
                    <br />
                    <hr />
                <h2 style="text-align: center" runat="server">Special Abilities</h2>
                    <strong>Name:</strong>
                    <asp:Textbox ID="txtBoxSplName" runat="server"></asp:Textbox>
                    <br /><br />
                    <strong>Description:</strong>
                    <asp:Textbox ID="txtBoxSplDesc" runat="server"></asp:Textbox>
                    <br />
                    <br />
                    <br />
                   <h2 style="text-align: center" runat="server">Get an E-mail of new Info</h2>
                    <strong>E-mail :</strong>
                    <asp:Textbox ID="TextboxEmail" runat="server"></asp:Textbox>
                    <strong>Name :</strong>
                    <asp:Textbox ID="TextboxEmailName" runat="server"></asp:Textbox>

            </div>
            <asp:Button runat="server" Text="Add" OnClick="addButton_Click" />
        </div>
    </div>
</asp:Content>

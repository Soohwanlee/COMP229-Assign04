<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="JSONProject.Update" %>
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
                <asp:Placeholder ID="plName" runat="server"></asp:Placeholder><br /><br />
                <strong>Faction : </strong>
                <asp:Placeholder ID="plFaction" runat="server"></asp:Placeholder><br /><br />
                <strong>Rank : </strong>
                <asp:Placeholder ID="plRank" runat="server"></asp:Placeholder><br /><br />
                <strong>Base : </strong>
                <asp:Placeholder ID="plBase" runat="server"></asp:Placeholder><br /><br />
                <strong>Size : </strong>
                <asp:Placeholder ID="plDeployment" runat="server"></asp:Placeholder><br /><br />
                <strong>Traits : </strong>
                <asp:Placeholder ID="plSize" runat="server"></asp:Placeholder><br /><br />
                <strong>Traits : </strong>
                <asp:Placeholder ID="plTraits" runat="server"></asp:Placeholder><br /><br />
                <strong>Types : </strong>
                <asp:Placeholder ID="plTypes" runat="server"></asp:Placeholder><br /><br />
                <strong>DefenceChart : </strong>
                <asp:Placeholder ID="plDefence" runat="server"></asp:Placeholder><br /><br />
                <strong>Mobility : </strong>
                <asp:Placeholder ID="plMobility" runat="server"></asp:Placeholder><br /><br />
                <strong>Resiliance</strong>
                <asp:Placeholder ID="plResiliance" runat="server"></asp:Placeholder><br /><br />
                <strong>Wounds : </strong>
                <asp:Placeholder ID="plWounds" runat="server"></asp:Placeholder><br /><br />
                <hr />

                <h2 style="text-align: center">Actions</h2>
                    <strong>Type:</strong>
                    <asp:Placeholder ID="plActName" runat="server"></asp:Placeholder>
                    <br /><br />
                    <strong>Type:</strong>
                    <asp:Placeholder ID="plActType" runat="server"></asp:Placeholder>
                    <br /><br />
                    <strong>Rating(Number):</strong>
                    <asp:Placeholder ID="plActRating" runat="server"></asp:Placeholder>
                    <br /><br />
                    <strong>Range:</strong>
                    <asp:Placeholder ID="plActRange" runat="server"></asp:Placeholder>
                    <br /><br />
                    <strong>Description:</strong>
                    <asp:Placeholder ID="plActDesc" runat="server"></asp:Placeholder>
                    <br />
                    <br />
                    <br />
                    <hr />
                <h2 style="text-align: center" runat="server">Special Abilities</h2>
                    <strong>Name:</strong>
                    <asp:Placeholder ID="plSplName" runat="server"></asp:Placeholder>
                    <br /><br />
                    <strong>Description:</strong>
                    <asp:Placeholder ID="plSplDesc" runat="server"></asp:Placeholder>
                    <br />
                    <br />
                    <br />

            </div>
            <asp:Button runat="server" Text="update" OnClick="updateButton_Click" />
        </div>
    </div>
</asp:Content>

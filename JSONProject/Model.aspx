<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Model.aspx.cs" Inherits="JSONProject.Model" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <center><asp:Image ID="ImageId" Width="300px" runat="server" /></center><br />
                <h3 style="text-align: center"><asp:Label ID="lblTitle" runat="server" Text=""></asp:Label></h3>
            </div>

            <div class="col-md-8">
                <h2 style="text-align: center">Model Detail</h2>
                <asp:Label ID="lblId" runat="server" Text=""></asp:Label>
                <br />
                <strong>Name : </strong>
                <asp:Label ID="lblName" runat="server" Text=""></asp:Label><br />
                <strong>Faction : </strong>
                <asp:Label ID="lblFaction" runat="server" Text=""></asp:Label><br />
                <strong>Rank : </strong>
                <asp:Label ID="lblRank" runat="server" Text=""></asp:Label><br />
                <strong>Base : </strong>
                <asp:Label ID="lblBase" runat="server" Text=""></asp:Label><br />
                <strong>Size : </strong>
                <asp:Label ID="lblDeployment" runat="server" Text=""></asp:Label><br />
                <strong>Traits : </strong>
                <asp:Label ID="lblSize" runat="server" Text=""></asp:Label><br />
                <strong>Traits : </strong>
                <asp:Label ID="lblTraits" runat="server" Text=""></asp:Label><br />
                <strong>Types : </strong>
                <asp:Label ID="lblTypes" runat="server" Text=""></asp:Label><br />
                <strong>DefenceChart : </strong>
                <asp:Label ID="lblDefence" runat="server" Text=""></asp:Label><br />
                <strong>Mobility : </strong>
                <asp:Label ID="lblMobility" runat="server" Text=""></asp:Label><br />
                <strong>Resiliance</strong><asp:Label ID="lblResiliance" runat="server" Text=""></asp:Label><br />
                <strong>Wounds : </strong>
                <asp:Label ID="lblWounds" runat="server" Text=""></asp:Label><br />
                <hr />
                <br />
                <h2 style="text-align: center">Actions</h2>
                <asp:Repeater ID="repeater2" runat="server">
                    <ItemTemplate>
                        <strong>Name : </strong><%# Eval("name") %><br />
                        <strong>Type : </strong><%# Eval("type") %><br />
                        <strong>Rating : </strong><%# Eval("rating") %><br />
                        <strong>Range : </strong><%# Eval("range") %><br />
                        <strong>Description : </strong><%# Eval("description") %><br />
                        <br />

                        <br />
                    </ItemTemplate>
                </asp:Repeater>
                <h2 ID="SpecialTitle" style="text-align: center" runat="server" visible="false">Special Abilities</h2>
                <asp:Repeater ID="repeater3" runat="server">
                    <ItemTemplate>
                        <strong>Name : </strong><%# Eval("name") %><br />
                        <strong>Description : </strong><%# Eval("description") %><br />
                        <br />

                        <br />
                    </ItemTemplate>
                </asp:Repeater>
                <asp:Button ID="Update" CssClass="btn btn-lg btn-info" runat="server" Text="Update" OnClick="Update_Click"  />

            </div>
        </div>
    </div>
</asp:Content>

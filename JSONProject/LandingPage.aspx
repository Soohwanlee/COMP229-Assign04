<%@ Page Title="title" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LandingPage.aspx.cs" Inherits="JSONProject.LandingPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <div class="container-fluid">
        <div class="row">
            <img src="Assets/images/WrathOfKings.png" alt="School" class="img-rounded img-responsive center-block">
        </div>

        <div class="row">

            <div class="col-md-3">
                <asp:Button CssClass="btn btn-lg btn-info" runat="server" Text="Add a New Model" OnClick="addButton_Click" />
            </div>

            <div class="col-md-6">
                <h2 style="text-align: center">Model List</h2>
                <center>
     <asp:Repeater ID="repeater1" runat="server">
                <ItemTemplate>
                   
                    <img src="<%#Eval("imageUrl") %>" width=400px alt="<%# Eval("name") %>"" /><br />
                    <asp:LinkButton ID="PlayerNames" runat="server" Text='<%# Eval("name")%>' PostBackUrl='<%#string.Format("Model.aspx?name={0}&faction={1}", Eval("name"), Eval("faction")) %>' />
                    <br />
                    <hr />
                    <br />
                </ItemTemplate>
     </asp:Repeater>
                 </center>
            </div>
            <div class="col-md-3">
            </div>

        </div>
    </div>
</asp:Content>

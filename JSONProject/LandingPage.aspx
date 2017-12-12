<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LandingPage.aspx.cs" Inherits="JSONProject.LandingPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <div class="container-fluid">
        <div class="row">
            <!--I got this image from picture of the Seoul university's hospital  -->
            <img src="Assets/images/WrathOfKings.png" alt="School" class="img-rounded img-responsive center-block">
        </div>

        <div class="row">
        <h1 class="text-center">Welcome and Enjoy the game!!</h1>
        <div class="col-md-6">
            <h2 style="text-align: center">Current Student's list</h2>
        </div>

        <div class="col-md-6">

            <h2 style="text-align: center">Registration</h2>
            <center>
            <div style="padding:5px">
            First Name : <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
                    <br />
            </div>
            <div style="padding:5px">
            Last Name : <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
                <br />
            <br />
            </div>
        </div>
        </center>
    </div>
    </div>
</asp:Content>

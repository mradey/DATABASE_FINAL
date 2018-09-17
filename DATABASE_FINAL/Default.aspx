<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="DATABASE_FINAL._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Intro to Databases Final Project</h1>
        <p class="lead">This project requires the students to create a website using the tools listed below. The site should include at least login page, home page, data management page, query page & data display pages, logout page, and admin page. </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Data Management Page</h2>
            <p>
                Allows you to create a database, populate that database with tables, and then insert employees into departments or update an employees information
            </p>
            <p>
                <a class="btn btn-default" href="DataManagement.aspx">Data Management &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Execute Queries</h2>
            <p>
                Allows users to execute queries against database to get information.  There are 6 queries that can be found on this page    
            </p>
            <p>
                <a class="btn btn-default" href="Queries.aspx">Execute Queries &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Log out</h2>
            <p>
                Use this link to log out!
            </p>
            <p>
                <a class="btn btn-default" href="Login.aspx">Log out &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TestWeb.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">

    <nav style="--bs-breadcrumb-divider: '>'; font-size: 14px">
    <ol class="breadcrumb">
        <li class="breadcrumb-item">
            <i class="fa-solid fa-house">  </i>
        </li>
        <li class="breadcrumb-item">Home</li>
    </ol>
</nav>

<hr>
<div class="row">
    <div class="col">
        <h1>Dashboard</h1>
<p class="text-muted">Resumen</p>
<div class="jumbotron">
    <h1 class="display-4">Hola Mundo!!</h1>
    <p class="lead">Este es un diseño simple de un sistema web para cualquier propósito</p>
    <hr class="my-4">
    <p>Aquí usamos Bootstrap para darle un estilo adaptativo (responsive) al sitio web. </p>
    <a class="btn btn-primary btn-lg" href="/Views/Areas.aspx" role="button">También mostramos un ejemplo de CRUD</a>
</div>
    </div>
</div>

    
</asp:Content>

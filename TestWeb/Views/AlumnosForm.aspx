<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="AlumnosForm.aspx.cs" Inherits="TestWeb.Views.AlumnosForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    Registrar Alumno
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Scripts" runat="server">
    <script src="/Scripts/Alumnos.js?version=1.1" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
    <nav style="--bs-breadcrumb-divider: '>'; font-size: 14px">
        <ol class="breadcrumb">
            <li class="breadcrumb-item">
                <i class="fa-solid fa-house"></i>
            </li>
            <li class="breadcrumb-item">Alumnos</li>
            <li class="breadcrumb-item">Registrar</li>
        </ol>
    </nav>

    <div class="container">
        <div class="card">
            <div class="card-header">
                <h2>Registrar Alumno</h2>
            </div>
            <div class="card-body">
                <div class="mb-3 row">
                    <label for="TxtId" class="col-sm-2 col-form-label">Id Alumno</label>
                    <div class="col-sm-4">
                        <asp:TextBox ID="TxtId" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-sm-2"></div>
                    <div class="col-sm-4">
                        <asp:CheckBox ID="TxtActivo" runat="server" Text ="Activo" CssClass="form-check"/>
                    </div>
                </div>
                <div class="mb-3 row">
                    <label for="TxtNombre" class="col-sm-2 col-form-label">Nombre</label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control" required="true"></asp:TextBox>
                    </div>
                </div>
                <div class="mb-3 row">
                    <label for="TxtApellidos" class="col-sm-2 col-form-label">Apellidos</label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="TxtApellidos" runat="server" CssClass="form-control"  required="true"></asp:TextBox>
                    </div>
                </div>
                <div class="mb-3 row">
                    <label for="TxtCiclo" class="col-sm-2 col-form-label">Ciclo</label>
                    <div class="col-sm-4">
                        <asp:TextBox ID="TxtCiclo" runat="server" type="number" CssClass="form-control" required="true" ></asp:TextBox>
                    </div>
                    <label for="TxtMensualidad" class="col-sm-2 col-form-label">Mensualidad</label>
                    <div class="col-sm-4">
                        <asp:TextBox ID="TxtMensualidad" runat="server" type="number" step="any" CssClass="form-control" required="true"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="card-footer clearfix">
                <asp:Button ID="BtnRegresar" runat="server" Text="Regresar" UseSubmitBehavior="false"
                    CssClass="float-start btn btn-secondary" OnClick="BtnRegresar_Click"/>
                <asp:Button ID="BtnGuardar" runat="server" Text="Guardar"
                    CssClass="float-end btn btn-primary" OnClick="BtnGuardar_Click"/>
            </div>
        </div>
    </div>
</asp:Content>

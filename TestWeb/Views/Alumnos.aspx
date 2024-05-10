<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Alumnos.aspx.cs" Inherits="TestWeb.Views.Alumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    Listado de Alumnos
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Scripts" runat="server">
    <script src="/Scripts/Alumnos.js" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">  

    <nav style="--bs-breadcrumb-divider: '>'; font-size: 14px">
        <ol class="breadcrumb">
            <li class="breadcrumb-item">
                <i class="fa-solid fa-house"></i>
            </li>
            <li class="breadcrumb-item">Alumnos</li>
            <li class="breadcrumb-item">Listar</li>
        </ol>
    </nav>
    
    <div class="container">    
        <h2> Listado de Alumnos </h2>
        
        <div class="container row">  
            <div class="text-end p-3">  
                <asp:LinkButton ID="BtnAgregar" runat="server" Text="<i class='fas fa-plus pe-2'> </i> Agregar" 
                    OnClick="BtnAgregar_Click" CssClass="btn btn-success" />
            </div>
        </div>

        <div class="container row">   
            <asp:GridView ID="GridAlumnos" runat="server"  AutoGenerateColumns="false"
                AllowPaging="true" PageSize="5" OnPageIndexChanging="GridAlumnos_PageIndexChanging"
                CssClass="table table-hover table-responsive table-striped">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Apellidos" HeaderText="Apellidos"/>
                    <asp:BoundField DataField="Ciclo" HeaderText="Ciclo"/>
                    <asp:BoundField DataField="Mensualidad" HeaderText="Mensualidad" />                    
                    <asp:CheckBoxField DataField="Activo" HeaderText="Activo"/> 
                    <asp:TemplateField HeaderText="">
                         <ItemTemplate>
                             <asp:LinkButton ID="BtnEditar" runat="server" Text="<i class='fas fa-edit ps-2'>  </i>"
                                 OnClick="BtnEditar_Click" CommandArgument='<%# Eval("Id") %>'/>
                             <asp:LinkButton ID="BtnEliminar" runat="server" Text="<i class='fas fa-trash ps-2'>  </i>"
                                 OnClick="BtnEliminar_Click" CommandArgument='<%# Eval("Id") %>'
                                 OnClientClick="return confirm('¿Esta seguro de eliminar este registro?');" />
                         </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" Width="100px" />
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>

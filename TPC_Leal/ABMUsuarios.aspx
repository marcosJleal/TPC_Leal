<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ABMUsuarios.aspx.cs" Inherits="TPC_Leal.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Listado de Articulos</h1>
    
        
            <asp:GridView CssClass="table table-striped table-dark" ID="dgvUsuarios" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="dgvUsuarios_SelectedIndexChanged" OnRowCommand="dgvUsuarios_RowCommand">
        <Columns>
           
            <asp:BoundField HeaderText="IdUsuario" DataField="IdUsuario" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
            <asp:BoundField HeaderText="DNI" DataField="DNI" />
            <asp:BoundField HeaderText="Email" DataField="Email" />
            <asp:BoundField HeaderText="TipoUsuario" DataField="TipoUsuario" />
            <asp:ButtonField HeaderText="Eliminar" ButtonType="Link" Text="Eliminar" CommandName="Select" />
            <asp:ButtonField HeaderText="Modificar" ButtonType="Link" Text="Modificar" CommandName="Select2" />
            
        </Columns>

    </asp:GridView>
    <div>
         <a href="/AltaUsuario.aspx" class="btn btn-dark">Agregar Usuario</a>
    </div>
    <div style="margin-top:5px">
        <a href="/default.aspx" class="btn btn-dark">Inicio</a>
    </div>
</asp:Content>

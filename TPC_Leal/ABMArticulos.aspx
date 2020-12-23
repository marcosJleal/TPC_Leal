<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ABMArticulos.aspx.cs" Inherits="TPC_Leal.AMBArticulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Listado de Articulos</h1>
    
        
            <asp:GridView CssClass="table table-striped table-dark" ID="dgvArticulos" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvArticulos_SelectedIndexChanged" OnRowCommand="dgvArticulos_RowCommand">
        <Columns>
           
            <asp:BoundField HeaderText="IdArticulo" DataField="IdArticulo" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Stock" DataField="Stock" />
            <asp:BoundField HeaderText="Precio" DataField="Precio" />
            <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
            <asp:BoundField HeaderText="Destacado" DataField="Destacado" />
            <asp:ButtonField HeaderText="Eliminar" ButtonType="Link" Text="Eliminar" CommandName="Select" />
            <asp:ButtonField HeaderText="Modificar" ButtonType="Link" Text="Modificar" CommandName="Select2" />
            <asp:ButtonField HeaderText="Restaurar" ButtonType="Link" Text="Restaurar" CommandName="Select3" />
            <asp:ButtonField HeaderText="Restaurar" ButtonType="Link" Text="Destacar" CommandName="Select4" />
            
        </Columns>

    </asp:GridView>
    <div>
         <a href="/AltaArticulo.aspx" class="btn btn-dark">Agregar Articulos</a>
    </div> 
    <div>
        <asp:Button Text="Articulos Eliminados" style="margin-top:5px" CssClass="btn btn-dark" ID="btnEliminados" runat="server"  Width="159px" OnClick="btnEliminados_Click" />
    </div>
    <div style="margin-top:5px">
        <a href="/default.aspx" class="btn btn-dark">Inicio</a>
    </div>
    
</asp:Content>

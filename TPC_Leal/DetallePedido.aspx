<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DetallePedido.aspx.cs" Inherits="TPC_Leal.DetallePedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 style="text-align:center">Detalles</h1>
    
        
            <asp:GridView CssClass="table table-striped table-dark" ID="dgvDetalles" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvDetalles_SelectedIndexChanged" OnRowCommand="dgvDetalles_RowCommand">
        <Columns>
           
            <asp:BoundField HeaderText="IdDetalle" DataField="ID" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
            <asp:BoundField HeaderText="Articulo" DataField="item.articulo.Nombre" />
<%--            <asp:BoundField HeaderText="Email" DataField="pedido.Usuario.Email" />--%>
            <asp:BoundField HeaderText="Color" DataField="item.Color.Nombre" />
            <asp:BoundField HeaderText="Cantidad" DataField="item.Cantidad" />
            <asp:BoundField HeaderText="Precio" DataField="item.articulo.Precio" />
            <%--<asp:ButtonField HeaderText="Stock" ButtonType="Link"  Text="Descontar" CommandName="Select"  />--%>
           
            
        </Columns>

    </asp:GridView>
    <h1 style="margin-top:3%">Seguimiento</h1>
       <asp:GridView CssClass="table table-striped table-dark" ID="dgvSeguimiento" runat="server" AutoGenerateColumns="false" Height="163px" >
        <Columns>
           
            <asp:BoundField HeaderText="Fecha" DataField="Fecha" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
            <asp:BoundField HeaderText="Estado" DataField="Estado" />
        </Columns>
    </asp:GridView>
    <a href="/default.aspx" class="btn btn-dark">Inicio</a>
</asp:Content>

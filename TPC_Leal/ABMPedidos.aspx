<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ABMPedidos.aspx.cs" Inherits="TPC_Leal.ABMPedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <h1>Listado de Pedidos</h1>
    
        
            <asp:GridView CssClass="table table-striped table-dark" ID="dgvPedidos" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvPedidos_SelectedIndexChanged" OnRowCommand="dgvPedidos_RowCommand">
        <Columns>
           
            <asp:BoundField HeaderText="ID" DataField="ID" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
            <asp:BoundField HeaderText="Usuario" DataField="Usuario.Email" />
            <asp:BoundField HeaderText="Estado" DataField="Estado.estado" />
            <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
            <asp:BoundField HeaderText="Total" DataField="Carro.Subtotal" />
            <asp:ButtonField HeaderText="Actualizar Pedido" ButtonType="Link" Text="Actualizar Pedido" CommandName="Select" />
            <asp:ButtonField HeaderText="Detalles" ButtonType="Link" Text="Ver detalles" CommandName="Select2" />
            
        </Columns>

    </asp:GridView>

    <div style="margin-top:5px">
        <a href="/default.aspx" class="btn btn-dark">Inicio</a>
    </div>
</asp:Content>

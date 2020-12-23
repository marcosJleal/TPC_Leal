<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MisPedidos.aspx.cs" Inherits="TPC_Leal.MisPedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Mis Pedidos</h1>
      

              <div class="container">
  <div class="row">
    <div class="col">
      One of three columns
    </div>
    <div class="col">
        <asp:GridView CssClass="table table-striped table-dark" ID="dgvPedidos" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvPedidos_SelectedIndexChanged" OnRowCommand="dgvPedidos_RowCommand" >
        <Columns>
           
            <asp:BoundField HeaderText="ID" DataField="ID" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto"  />
            <%--<asp:BoundField HeaderText="Usuario" DataField="Usuario.Email" />--%>
            <asp:BoundField HeaderText="Estado" DataField="Estado.estado" />
            <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
            <asp:BoundField HeaderText="Total" DataField="Carro.Subtotal" />
            <asp:ButtonField HeaderText="Detalles" ButtonType="Link" Text="Ver detalles"  CommandName="Select" />
            
   
        </Columns>
             </asp:GridView>
    </div>
    <div class="col">
      One of three columns
    </div>
  </div>
</div>

</asp:Content>

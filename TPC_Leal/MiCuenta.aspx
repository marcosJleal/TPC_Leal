<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MiCuenta.aspx.cs" Inherits="TPC_Leal.MiCuenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="card" style="width: 35rem;margin-left:35%">
  <img src="Imagenes/user-icon-human-person-symbol-avatar-login-sign-vector-illustration-isolated-modern-background-user-icon-human-person-symbol-118096858.jpg" class="card-img-top" alt="...">
  <div class="card-body">

    <p class="card-text"> <asp:Label Text="Nombre: " runat="server" BorderStyle="None" Height="40px" />
        <asp:Label id="lblNombre" runat="server" Height="40px" Font-Size="Large" /></p>
  </div>
  <ul class="list-group list-group-flush">
    <li class="list-group-item">     <asp:Label Text="Apellido: " runat="server" Height="40px" Font-Size="Large" />
        <asp:Label id="lblApellido" runat="server" /></li>
    <li class="list-group-item">  <asp:Label Text="DNI: " runat="server" />
        <asp:Label id="lblDni" runat="server" /></li>
    <li class="list-group-item">         <asp:Label Text="Email: " runat="server" />
        <asp:Label id="lblEmail" runat="server" /></li>
  </ul>
  <div class="card-body">
       <asp:Button Text="Mis Pedidos" CssClass="btn btn-dark" ID="btnPedidos" runat="server" OnClick="btnPedidos_Click"  />
        <a href="/Default.aspx" class="btn btn-dark">Inicio</a>
  </div>
</div>

</asp:Content>

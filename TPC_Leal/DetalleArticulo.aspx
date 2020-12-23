<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="TPC_Leal.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    <div class="container">
  <div class="row">
  
    <div class="col-md">
      <div class="card" style="width: 35rem;">
  <img src="<%=ProdDetalle.UrlImagen %>" class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title"><%=ProdDetalle.Nombre %></h5>
    <p class="card-text"><%=ProdDetalle.Descripcion %></p>
  </div>
  <ul class="list-group list-group-flush">
    <li class="list-group-item"><%="Precio: " %><%="$"%><%=ProdDetalle.Precio %></li>
    <li class="list-group-item"><%="Stock: " %><%=ProdDetalle.Stock %> </li>
  </ul>
        <ul class="list-group list-group-flush">
            <li class="list-group-item">
                <asp:Label Text="Colores: " runat="server" />
                <asp:DropDownList ID="cboColores" runat="server"></asp:DropDownList>
            </li>
        </ul>
        <ul class="list-group list-group-flush">
            <li class="list-group-item">
                <asp:Button Text="Agregar" runat="server" ID="btnAgregar" cssclass="btn btn-primary" style="padding:2px" OnClick="btnAgregar_Click"/>
                <asp:Label Text="Cantidad" runat="server" />
                <asp:TextBox runat="server" Width="59px" ID="txtCantidad" />
            </li>
        </ul>
  <div class="card-body">
       <a href="/productos.aspx" class="btn btn-primary">Volver</a>
      </div>
  </div>
    </div>
    <div class="col-sm">
    
    </div>
  </div>
</div>
   
   
 

</asp:Content>

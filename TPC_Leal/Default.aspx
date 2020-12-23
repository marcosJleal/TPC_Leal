<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPC_Leal.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <%-- <div class="Container" style="background-color:white;Margin:0 20% 0 20%;padding-bottom:30px">--%>
    <img src="Imagenes/banner_Mesa%20de%20trabajo%201.jpg" class="img-fluid" alt="Responsive image" style="margin:2% 0 0 30%">
<%--        </div>--%>
        <h1 style="text-align: center;">Productos Destacados</h1>
    <div class="card-columns" style="margin: 20px 20px 20px 20px;">
        <%foreach (var item in listado)
            {        %>
        <div class="card text-white bg-dark mb-3" style="width: 18rem;">
            <img src="<% =item.UrlImagen %>" class="card-img-top" alt="...">
            <div class="card-body">
                <h5 class="card-title"><% =item.Nombre %></h5>
                <p class="card-text"><%=item.Descripcion %></p>
                <a href="DetalleArticulo.aspx?idart=<%=item.IdArticulo.ToString() %>" class="btn btn-primary">Detalle</a>
                <p class="d-inline p-2 bg-dark text-white">$ <%=item.Precio.ToString() %></p>
            </div>
        </div>
        <% } %>
        
    </div>
</asp:Content>

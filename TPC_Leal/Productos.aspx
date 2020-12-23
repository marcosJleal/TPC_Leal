<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="TPC_Leal.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h1 style="text-align: center;" >Productos</h1>
    <div style="margin-left:20px">
        <asp:Label Text="Categorias: " runat="server" />
         <asp:DropDownList CssClass="form-control" runat="server" ID="ddlCategorias" Width="305px"></asp:DropDownList>
        <asp:Button Text="Filtrar" CssClass="btn btn-dark" ID="btnFiltrar"  runat="server" OnClick="btnFiltrar_Click" />
        <a href="/Productos.aspx" class="btn btn-dark">Quitar filtro</a>
    </div>
   

    <div class="card-columns" style="margin: 20px 20px 20px 20px;">
        <%foreach (var item in listado)
            {        %>
       <%-- <%if (item.Categoria.IdCategoria == int.Parse(ddlCategorias.SelectedItem.Value))
            {%>--%>
        
        <div class="card text-white bg-dark mb-3" style="width: 18rem;">
            <img src="<% =item.UrlImagen %>" class="card-img-top" alt="...">
            <div class="card-body">
                <h5 class="card-title"><% =item.Nombre %></h5>
                <p class="card-text"><%=item.Descripcion %></p>
                <a href="DetalleArticulo.aspx?idart=<%=item.IdArticulo.ToString() %>" class="btn btn-primary">Detalle</a>
                <p class="d-inline p-2 bg-dark text-white">$ <%=item.Precio.ToString() %></p>
            </div>
        </div>
     <%--   <%}%>--%>
   
        <% } %>
        
    </div>
    
</asp:Content>


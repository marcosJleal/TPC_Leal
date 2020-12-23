<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPC_Leal.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
</head>
<body>

    <h1  style="text-align:center" >Login</h1>
    
    <form id="form1" runat="server">
        <div class="container-md" style="margin-top:5%">
            <form>
  <div class="form-group">
    <label for="exampleInputEmail1">Email address</label>
      <asp:TextBox  CssClass="form-control" ID="txtEmail" runat="server" />
    <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Password</label>
      <asp:TextBox   CssClass="form-control" ID="txtContraseña" runat="server" TextMode="Password" />
  </div>
  <div class="form-group ">
      <a href="/OlvideContraseña.aspx" style="margin-right:20px">Olvide mi contraseña</a>
      <a href="/AltaUsuario.aspx">Registrarse</a>
  </div>
                <asp:Button Text="GO" CssClass="btn btn-primary" type="Submit" ID="btnGO" runat="server" OnClick="btnGO_Click" />
</form>

        </div>
    </form>
</body>
</html>

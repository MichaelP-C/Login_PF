<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_PF.aspx.cs" Inherits="Login_PF.Login_PF" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/css/bootstrap.min.css" rel="stylesheet"/>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/js/bootstrap.bundle.min.js"></script>
    <title>Inicio de Sesión</title>
</head>
<body class="bg-light">
    <div>
         <div>
              <form id="formulario_login" runat="server">
                    <div class="form-control">
                        <div class="col-6  mb-5"> 
                            <asp:Label class="h3" ID="lblInicio" runat="server" Text="Login"></asp:Label>
                        </div>
                        <div>
                            <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
                            <asp:TextBox ID="tbUsuario" CssClass="form-control" runat="server" placeholder="Nombre de usuario"></asp:TextBox>
                        </div>
                        <div>
                            <asp:Label ID="lblContraseña" runat="server" Text="Contraseña:"></asp:Label>
                            <asp:TextBox ID="tbContraseña" CssClass="form-control" TextMode="Password" runat="server" placeholder="Contraseña"></asp:TextBox>
                        </div>
                        <div class="row">
                            <asp:Label ID="lblError" runat="server"></asp:Label>
                        <div/>
                         <br />
                         <div class="row">
                             <asp:Button ID="btnIngresar" CssClass="btn btn-primary btn-danger" runat="server" Text="Ingresar" OnClick="BtnIngresar_Click" />
                         </div>
                    </div>
             </form>
        </div>
    </div>
   
</body>
</html>

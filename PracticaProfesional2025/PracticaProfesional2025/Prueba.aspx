﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prueba.aspx.cs" Inherits="PracticaProfesional2025.Prueba" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtIngresoEdad" runat="server"></asp:TextBox>
        </br> </br>
        <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" />
        <asp:TextBox ID="txtEdad" runat="server" Text="Ingrese edad"></asp:TextBox>
        </br> </br>
        <asp:Label ID="lblMayor" runat="server" Text="" ForeColor="#009933"></asp:Label>
    </div>
    </form>
</body>
</html>

<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="PracticaProfesional2025.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="p-4 p-md-5 pt-5">
        <table class="table">
            <tr>
                <td>
                    <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvTxtUsuario" runat="server" ErrorMessage="El campo usuario es obligatorio" ForeColor="Red"
                        Text="*" ControlToValidate="txtUsuario"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDNI" runat="server" Text="DNI"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDNI" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvTxtDNI" runat="server" ErrorMessage="El campo dni es obligatorio" ForeColor="Red"
                        Text="*" ControlToValidate="txtDNI"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEdad" runat="server" Text="Edad"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvTxtEdad" runat="server" ErrorMessage="El campo Edad es obligatorio" ForeColor="Red"
                        Text="*" ControlToValidate="txtEdad"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvTxtEdad" runat="server" ErrorMessage="Debe mayor de 18 años" ControlToValidate="txtEdad" ForeColor="Red"
                        Type="Integer" Text="*" MaximumValue="100" MinimumValue="18"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblContraseña" runat="server" Text="Contraseña"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="El campo Contraseña es obligatorio" ForeColor="Red"
                        Text="*" ControlToValidate="txtContraseña"></asp:RequiredFieldValidator>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblRepetir" runat="server" Text="Contraseña"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRepetir" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvRepetir" runat="server" ErrorMessage="El campo repetir es obligatorio" ForeColor="Red"
                        Text="*" ControlToValidate="txtRepetir"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvRepetir" runat="server" ErrorMessage="Las contraseñas no coinciden" ForeColor="Red"
                        ControlToValidate="txtContraseña" ControlToCompare="txtRepetir" Text="*"></asp:CompareValidator>
                </td>
            </tr>
        </table>
        <asp:Button ID="btnGuardar" CssClass="btn-success" runat="server" Text="Guardar"
            OnClick="btnGuardar_Click" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" ForeColor="Red" />
        <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor="Green"> </asp:Label>
    </div>
</asp:Content>

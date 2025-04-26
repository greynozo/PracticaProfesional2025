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
                <td>    <asp:RequiredFieldValidator ID="rfvTxtUsuario" runat="server" ErrorMessage="*" ForeColor="Red"
                        Text="El campo usuario es obligatorio" ControlToValidate="txtUsuario"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDNI" runat="server" Text="DNI"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDNI" runat="server" TextMode="Number"></asp:TextBox>
                    
                </td>
                <td><asp:RequiredFieldValidator ID="rfvTxtDNI" runat="server" ErrorMessage="RequiredFieldValidator"
                        Text="El campo dni es obligatorio" ControlToValidate="txtDNI"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEdad" runat="server" Text="Edad"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
                    
                </td>
                <td><asp:RequiredFieldValidator ID="rfvTxtEdad" runat="server" ErrorMessage="RequiredFieldValidator"
                        Text="El campo Edad es obligatorio" ControlToValidate="txtEdad"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvTxtEdad" runat="server" ErrorMessage="RangeValidator" ControlToValidate="txtEdad" Type="Integer" Text="Debe mayor de 18 años" MaximumValue="100" MinimumValue="18"></asp:RangeValidator></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblContraseña" runat="server" Text="Contraseña"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password"></asp:TextBox>
                    
                </td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"
                        Text="El campo Contraseña es obligatorio" ControlToValidate="txtContraseña"></asp:RequiredFieldValidator>
                  </tr>
            <tr>
                <td>
                    <asp:Label ID="lblRepetir" runat="server" Text="Contraseña"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRepetir" runat="server" TextMode="Password"></asp:TextBox>
                   
                </td>
                <td> <asp:RequiredFieldValidator ID="rfvRepetir" runat="server" ErrorMessage="RequiredFieldValidator"
                        Text="El campo repetir es obligatorio" ControlToValidate="txtRepetir"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvRepetir" runat="server" ErrorMessage="Las contraseñas no coinciden"
                        ControlToValidate="txtContraseña" ControlToCompare="txtRepetir" Text="*" ></asp:CompareValidator></td>
             <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
            BackColor="#333300" DisplayMode="List" ShowMessageBox="True" />
            </tr>
        </table>
        <asp:Button ID="btnGuardar" CssClass="btn-success" runat="server" 
            Text="Guardar" onclick="btnGuardar_Click" />
    </div>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true"
    CodeBehind="Vista.aspx.cs" Inherits="PracticaProfesional2025.Vista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="p-4 p-md-5 pt-5">
        <asp:GridView ID="GridView1" CssClass="table" runat="server" AutoGenerateColumns="False" DataKeyNames="ID"
            DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True"
                    SortExpression="ID" />
                <asp:BoundField DataField="USUARIO" HeaderText="USUARIO" SortExpression="USUARIO" />
                <asp:BoundField DataField="PASS" HeaderText="PASS" SortExpression="PASS" />
                <asp:BoundField DataField="EDAD" HeaderText="EDAD" SortExpression="EDAD" />
                <asp:BoundField DataField="DNI" HeaderText="DNI" SortExpression="DNI" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CadenaPP2025 %>"
            SelectCommand="SELECT * FROM [USUARIO]"></asp:SqlDataSource>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="istek.aspx.cs" Inherits="istek" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList3" runat="server" 
        onselectedindexchanged="DataList3_SelectedIndexChanged">
    <ItemTemplate>
        <table align="center" cellpadding="0" cellspacing="0" class="style7">
            <tr>
                <td class="style8" rowspan="2">
                    <img alt="" src="images/<%#Eval("foto")%>" style="height: 64px; width: 60px" />
                </td>
                <td class="style10">
                    <asp:Label ID="Label3" runat="server" style="font-size: small" ><%#Eval("adi")%></asp:Label>
                    <asp:Label ID="Label4" runat="server" style="font-size: small" ><%#Eval("soyadi")%></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style10">
                    <a href="istek.aspx?istek=<%#Eval("uyeID")%>">Onayla</asp:LinkButton>
                </td>
            </tr>
        </table>
    </ItemTemplate>
</asp:DataList>
</asp:Content>


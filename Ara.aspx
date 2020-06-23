<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Ara.aspx.cs" Inherits="Ara" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style17
        {
            width: 100%;
        }
        .style18
        {
            width: 14px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:DataList ID="DataList3" runat="server">
        <ItemTemplate>
            <table class="style17">
                <tr>
                    <td class="style18">
                        <img alt="" src="images/<%#Eval("foto")%>" />
                    </td>
                    <td>
                          
                <%#Eval("adi") %>&nbsp;<%#Eval("soyadi") %></td>
                    <td>
                        <a href="Default.aspx?Kisi=<%#Eval("uyeID")%>">Arkadaş Ekle</a></td>
                </tr>
            </table>  </ItemTemplate>
    </asp:DataList>

    </asp:Content>


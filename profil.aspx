<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="profil.aspx.cs" Inherits="profil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style14
    {
        width: 100%;
    }
    .style15
    {
        color: #475F92;
    }
    .style18
    {
        color: #475F92;
        width: 35px;
    }
    .style20
    {
        color: #475F92;
        width: 128px;
    }
    .style21
    {
        font-family: Georgia;
        font-size: large;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" class="style14">
    <tr>
        <td class="style21">
            adını</td>
        <td class="style18">
            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="değiştir" 
                Width="35px" />
        </td>
        <td class="style20">
            <asp:TextBox ID="txtadi" runat="server" Width="215px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style21">
            soyadı</td>
        <td class="style18">
            <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="değiştir" 
                Width="35px" />
        </td>
        <td class="style20">
            <asp:TextBox ID="txtsoyadi" runat="server" Width="215px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style21">
            e-posta</td>
        <td class="style18">
            <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="değiştir" 
                Width="35px" />
        </td>
        <td class="style20">
            <asp:TextBox ID="txteposta" runat="server" Width="215px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style21">
            foto</td>
        <td class="style18">
            <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="değiştir" 
                Width="35px" />
        </td>
        <td class="style20">
            <asp:FileUpload ID="FileUpload1" runat="server" Width="215px" />
        </td>
    </tr>
    <tr>
        <td class="style21">
            şifre</td>
        <td class="style18">
            <asp:Button ID="Button6" runat="server" onclick="Button6_Click" Text="değiştir" 
                Width="35px" />
        </td>
        <td class="style20">
            <asp:TextBox ID="txtsifre" runat="server" Width="215px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style15">
            &nbsp;</td>
        <td class="style18">
            &nbsp;</td>
        <td class="style20">
            <asp:Button ID="Button7" runat="server" onclick="Button7_Click" 
                Text="Güncelle" />
        </td>
    </tr>
</table>
</asp:Content>


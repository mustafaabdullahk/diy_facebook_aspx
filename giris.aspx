<%@ Page Language="C#" AutoEventWireup="true" CodeFile="giris.aspx.cs" Inherits="giris" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style2
        {
            width: 100%;
            border-bottom-style:none;
            border-bottom-color:"#3B5998";
        }
        .style3
        {
            background-color: #3B5998;
            height: 85px;
        }
        .style4
        {
            color: #FFFFFF;
            background-color: #3B5998;
            height: 85px;
            font-size: xx-large;
            width: 67%;
        }
        .style5
        {
            color: #000000;
        }
        .style7
        {
            color: #FFFFFF;
            font-size: large;
        }
        .style11
        {
            background-color: #E5E8F1;
            width: 391px;
        }
        .style16
        {
            color: #FFFFFF;
            width: 69%;
            background-color: background-color: #E5E8F1;;
        }
        .style17
        {
            width: 547px;
            height: 245px;
            background-color: #E5E8F1;
        }
        .style18
        {
            color: #3B5998;
        }
        .style19
        {
            color: #3B5998;
            width: 69%;
            background-color: background-color: #E5E8F1;;
        }
        .style20
        {
            background-color: #E5E8F1;
            font-family: "lucida grande", tahoma, verdana, arial, sans-serif;
            font-weight: bold;
            font-size: large;
        }
        .style21
        {
            font-family: "lucida grande", tahoma, verdana, arial, sans-serif;
            font-weight: bold;
            font-size: large;
        }
        .style22
        {
            color: #3B5998;
            width: 67%;
            background-color: background-color: #E5E8F1;;
        }
    </style>
</head>
<body style="background-color: #E5E8F1;" >
    <form id="form1" runat="server" 
    style="border-color: #3B5998; border-style: none; border-top-width: inherit">
    
   
    <table class="style2" 
        style="border-width: 0px; border-style: none; height: 423px;">
        <tr>
            <td class="style4" align="center">
                KAYABOOK</td>
            <td align="right" class="style3" colspan="2" valign="middle">
                <span class="style7">Ad</span><asp:TextBox ID="txtgirad" runat="server" 
                    CssClass="style5" Height="19px"></asp:TextBox>
                <span class="style7">Şifre</span><asp:TextBox ID="txtgirsifre" runat="server" 
                     Height="19px" Width="131px"></asp:TextBox>
        <asp:Button ID="butgir" runat="server" Text="Giriş" CssClass="style5" Height="24px" 
                    onclick="butgir_Click" />
    
            </td>
        </tr>
        <tr>
            <td class="style22" align="center">
                <span class="style21">K</span><span class="style20" 
                    style="color: rgb(14, 56, 95); font-style: normal; font-variant: normal; letter-spacing: normal; line-height: 29px; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: -1px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; display: inline !important; float: none;">ayabook 
                tanıdıklarınla iletişim kurmanı ve hayatında olup bitenleri paylaşmanı sağlar.</span></td>
            <td align="right" class="style19" colspan="2" valign="middle">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style11" colspan="2" rowspan="7">
                <img alt="" class="style17" src="book.png" /></td>
        </tr>
        <tr>
            <td align="center" class="style19">
                KAYDOL</td>
        </tr>
        <tr>
            <td align="right" class="style16">
                <span class="style18">Adınızı Giriniz:</span><asp:TextBox ID="txtad" 
                    runat="server" CssClass="style18"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style16">
                <span class="style18">soyadınızı Giriniz:</span><asp:TextBox ID="txtsoyad" 
                    runat="server" CssClass="style18"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style16">
                <span class="style18">E-posta</span><asp:TextBox ID="txteposta" runat="server" 
                    CssClass="style18"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style16">
                <span class="style18">şifre</span><asp:TextBox ID="txtsifre" runat="server" 
                    CssClass="style18"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style16">
                <asp:Button ID="butkaydol" runat="server" 
                    style="background-color: #69A74E" Text="KAYDOL" 
                    onclick="butkaydol_Click" CssClass="style18" />
                <span class="style18">
                <asp:Image ID="Image1" runat="server" Height="29px" ImageAlign="Top" 
                    Visible="False" Width="33px" />
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                </span>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>

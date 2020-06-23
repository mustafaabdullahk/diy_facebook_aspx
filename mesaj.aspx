<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="mesaj.aspx.cs" Inherits="mesaj" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Button ID="Button2" runat="server" Text="mesaj gönder" 
        onclick="Button2_Click" />
        <asp:Button ID="Button6" runat="server" onclick="Button6_Click" 
    Text="mesaj oku" />
        <asp:Panel ID="Panel1" runat="server" Visible="False">
        <table><tr><td>
    <div>
        <asp:Label ID="isim0" runat="server" ForeColor="#339933"></asp:Label>
        <asp:Label ID="isim1" runat="server" ForeColor="#339933"></asp:Label>
        <br />
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False"  Height="191px" 
            Width="238px">
            <Fields>
                <asp:BoundField DataField="adi" HeaderText="adi" 
                    SortExpression="adi" />
                <asp:BoundField DataField="soyadi" HeaderText="soyadi"  SortExpression="soyadi"/>
                <asp:BoundField DataField="eposta" HeaderText="eposta" 
                    SortExpression="eposta" />
                
               
                
            </Fields>
        </asp:DetailsView>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/webkent1.mdb" 
            SelectCommand="SELECT * FROM [uyeler] WHERE ([adisoyadi] = ?)">
            <SelectParameters>
                <asp:QueryStringParameter Name="adisoyadi" QueryStringField="adisoyadi" 
                    Type="String" />
            </SelectParameters>
        </asp:AccessDataSource>
        <asp:HyperLink ID="geri0" runat="server" NavigateUrl="~/Default.aspx">Anasayfa</asp:HyperLink>
        <br />
    </div>
    </td></tr></table>
    <table class="style1">
        <tr>
            <td>
                <asp:Label ID="isim" runat="server" ForeColor="#339933"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;Kime :
                <asp:Label ID="lblkime" runat="server"></asp:Label>
                <asp:Label ID="kimden" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Tarih :
                <asp:Label ID="tarih" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Mesaj"></asp:Label>
                :
                <asp:TextBox ID="pmesaj" runat="server" Height="114px" TextMode="MultiLine" 
                    Width="230px"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Gönder" />
                <asp:Label ID="onay" runat="server"></asp:Label>
                <br />
                <asp:HyperLink ID="geri" runat="server" NavigateUrl="~/Default.aspx">Anasayfa</asp:HyperLink>
                <br />
                <br />
            </td>
        </tr>
    </table></asp:Panel><asp:Panel ID="Panel2" runat="server" Visible="False">
    <table><tr><td>
        <div>
            <asp:Label ID="isim2" runat="server" ForeColor="#339933"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                CellPadding="4" CssClass="style1" 
                ForeColor="#333333" GridLines="None" Height="129px" 
                Width="432px">
                <RowStyle BackColor="#EFF3FB" />
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" runat="server" 
                                ImageUrl='<%# Eval("durumres") %>' 
                                NavigateUrl='<%# Eval("mesajid", "mesajoku.aspx?mesajid={0}") %>'></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField DeleteText="Sil" ShowDeleteButton="True" />
                    <asp:TemplateField HeaderText="kimden">
                        <ItemTemplate>
                            <%# Eval("kimden")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="durum">
                        <ItemTemplate>
                            <%# Eval("durum")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="tarih">
                        <ItemTemplate>
                            <%# Eval("tarih")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <AlternatingRowStyle BackColor="White" />
            </asp:GridView>
            <asp:HyperLink ID="geri1" runat="server" NavigateUrl="~/Default.aspx">Anasayfa</asp:HyperLink>
                 
            
            <br />
            <br />
        </div>
        </td></tr></table></asp:Panel>
</asp:Content>




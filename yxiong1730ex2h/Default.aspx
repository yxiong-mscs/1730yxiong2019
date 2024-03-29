﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="yxiong1730ex2h._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-6">
            <h2>DateTime Methods</h2>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="1) DateTime.Now: "></asp:Label>
                <asp:TextBox ID="TextBox1aResult" runat="server" Enabled="False"></asp:TextBox>
                <asp:TextBox ID="TextBox1bResult" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="2) DateTime.Today: "></asp:Label>
                <asp:TextBox ID="TextBox2aResult" runat="server" Enabled="False"></asp:TextBox>
                <asp:TextBox ID="TextBox2bResult" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="3) DateTime.Today: "></asp:Label>
                <asp:TextBox ID="TextBox3aResult" runat="server" Enabled="False" Width="40px"></asp:TextBox>
                <asp:TextBox ID="TextBox3bResult" runat="server" Enabled="False" Width="30px"></asp:TextBox>
                <asp:TextBox ID="TextBox3cResult" runat="server" Enabled="False" Width="30px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="4) DateTime.AddDays(90): "></asp:Label>
                <asp:TextBox ID="TextBox4Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="5) DateTime.AddMonths(3): "></asp:Label>
                <asp:TextBox ID="TextBox5Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="6) DateTime (y, m, d): "></asp:Label>
                <asp:TextBox ID="TextBox6a" runat="server" Width="40px">2019</asp:TextBox>
                <asp:TextBox ID="TextBox6b" runat="server" Width="30px">11</asp:TextBox>
                <asp:TextBox ID="TextBox6c" runat="server" Width="30px">16</asp:TextBox>
            &nbsp;<asp:TextBox ID="TextBox6Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="7) DateTime.Parse(): "></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server">November 1, 2019</asp:TextBox>
                <asp:TextBox ID="TextBox7Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label8" runat="server" Text="8) DateTime.TryParse(): "></asp:Label>
                <asp:TextBox ID="TextBox8" runat="server">November 1, 2019</asp:TextBox>
                <asp:TextBox ID="TextBox8Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label9" runat="server" Text="9) DateA - DateB: "></asp:Label>
                <asp:TextBox ID="TextBox9a" runat="server" Width="100px">1/1/2019</asp:TextBox>
                <asp:TextBox ID="TextBox9b" runat="server" Width="100px">12/12/18</asp:TextBox>
                <asp:TextBox ID="TextBox9Result" runat="server" Enabled="False" Width="77px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label10" runat="server" Text="10) DateA &gt; DateB: "></asp:Label>
                <asp:TextBox ID="TextBox10a" runat="server" Width="100px">1/1/2019</asp:TextBox>
                <asp:TextBox ID="TextBox10b" runat="server" Width="100px">2/1/2019</asp:TextBox>
                <asp:TextBox ID="TextBox10Result" runat="server" Enabled="False" Width="128px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="DateCalculationButton" runat="server" Text="Date Calculations" OnClick="DateCalculationButton_Click" />
            </div>
        </div>
        <div class="col-md-6">
            <h2>String Methods</h2>
            <div class="form-group">
                <asp:Label ID="Label11" runat="server" Text="1) Remove/Insert: "></asp:Label>
                <asp:TextBox ID="TextBox11" runat="server">late</asp:TextBox>
                <asp:TextBox ID="TextBox11Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label12" runat="server" Text="2) Remove/Insert: "></asp:Label>
                <asp:TextBox ID="TextBox12" runat="server">cater</asp:TextBox>
                <asp:TextBox ID="TextBox12Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label13" runat="server" Text="3) Substring/ToUpper: "></asp:Label>
                <asp:TextBox ID="TextBox13" runat="server">ABBlue22</asp:TextBox>
                <asp:TextBox ID="TextBox13Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label14" runat="server" Text="4) PadLeft: "></asp:Label>
                <asp:TextBox ID="TextBox14" runat="server">123.45</asp:TextBox>
                <asp:TextBox ID="TextBox14Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label15" runat="server" Text="5) Replace: "></asp:Label>
                <asp:TextBox ID="TextBox15" runat="server">(123)456-7890</asp:TextBox>
                <asp:TextBox ID="TextBox15Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label16" runat="server" Text="6) Replace/Length/Insert"></asp:Label>
                <asp:TextBox ID="TextBox16" runat="server">(123)456-7890</asp:TextBox>
                <asp:TextBox ID="TextBox16Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label17" runat="server" Text="7) ToLower/Contains: "></asp:Label>
                <asp:TextBox ID="TextBox17" runat="server">308 PiOnEer Rd</asp:TextBox>
                <asp:TextBox ID="TextBox17Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label18" runat="server" Text="8) IndexOf/Substring: "></asp:Label>
                <asp:TextBox ID="TextBox18" runat="server" Width="163px">1250 Homer Rd, Winona</asp:TextBox>
                <asp:TextBox ID="TextBox18Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label19" runat="server" Text="9) LastIndexOf/Substring: "></asp:Label>
                <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                <asp:TextBox ID="TextBox19Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label20" runat="server" Text="10) StringBuilder.Append: "></asp:Label>
                <asp:Label ID="Label20Result" runat="server" Text="[Label20Result]"></asp:Label>
            </div>
            <div class="form-group">
                <asp:Button ID="StringCalcButton" runat="server" Text="String Calculation" OnClick="StringCalcButton_Click" />
            </div>
        </div>
    </div>

</asp:Content>

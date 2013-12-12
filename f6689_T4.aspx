<%@Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="f6689_T4.aspx.cs" Inherits="f6689_T4" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="testi" runat="server"></asp:Label><br />
        <asp:Button ID="kaikki" runat="server" Text="Hae kaikki oppilaat" OnClick="kaikki_Click" />
        <asp:Button ID="kaikki_aak" runat="server" Text="Hae Kaikki oppilaat aakkosjärjestyksessä" OnClick="kaikki_aak_Click" />
        <asp:Button ID="valittu_op" runat="server" Text="Hae oppilaat valitulta opintojaksolta" OnClick="valittu_op_Click" />
        <asp:Button ID="valittu_oppilas" runat="server" Text="Hae valitun oppilaan läsnäolot" OnClick="valittu_oppilas_Click" />
        <br />
        <asp:DropDownList ID="opintojaksot" runat="server"></asp:DropDownList>
        <asp:DropDownList ID="oppilaat" runat="server"></asp:DropDownList><br />
        <asp:Label ID="ilm" runat="server"></asp:Label>
        <asp:GridView ID="grid" runat="server"></asp:GridView>
 </asp:Content>
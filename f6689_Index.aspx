<%@ Page Language="C#" AutoEventWireup="true" CodeFile="f6689_Index.aspx.cs" Inherits="f6689_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Jan Berg F6689</h1>
    <img src="Images/omakuva.gif" />
    <form id="form1" runat="server">
    <div>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/f6689_T2.aspx">Tehtävä 2</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/f6689_T3b.aspx">Tehtävä 3</asp:HyperLink>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/f6689_T4.aspx">Tehtävä 4</asp:HyperLink>
    </div>

    PALAUTE: Koe tuntui sopivan haastavalta, ja siitä syytä tosiaan muutama tehtävä jäi vaiheeseen. Tässä ajassa ei kerennyt enää oikeastaan pelkästään googleen nojaamaan
    ja opettelemaan uusia asioita (esim itselläni ongelma kuinka valikoida tulokset jos datasettiin lataa XML tiedoston; syy miksi kolmos tehtävä jäi isolta osin vaiheeseen).<br /><br />

    PISTEARVIOT:<br />
        -Tehtävä 1: 4p (Kaiken pitäisi toimi niinkun pitää)<br />
        -Tehtävä 2: 6p (Toimii niinkuin pitää)<br />
        -Tehtävä 3b: 7p (config tiedoston käyttö, tuntikirjausten lukumäärä, kirjausten lisääminen, validoinnit ja regex, virheenkäsittely)<br />
        -Tehtävä 4: 12p (Alkuilmoitus toimii, ilmoitus jos yhteys ei toimi, kaikkien oppilaiden haku, kaikki oppilaat kerran aakkosjärjestyksessä, valitun opintojakson oppilaiden haku,<br />
        valitun oppilaan läsnäolojen haku, viestit käyttäjälle, masterpage)<br />
        Oikea hakemistorakenne: 3p<br />

        Total: 32 pistettä.
    </form>
</body>
</html>

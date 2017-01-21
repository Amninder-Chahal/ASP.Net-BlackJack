<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Play Blackjack</title>
    <link href="Stylesheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="content">
    <header>
        <p class="headerText">BlackJack</p>
    </header>
    <form id="form1" runat="server">
     <p class="text para"><asp:Label ID="labelPara" runat="server" Text="Click Deal to start playing the game"></asp:Label></p><br />
   <div class="textContainer">
    <div class="table">
        <div class="row">
            <div class="column col-1">
                <p class="text"><asp:Label ID="labelUserScore" runat="server" Text=""> </asp:Label></p>
            </div>
            <div class="column col-2">
                <p class="text"><asp:Label ID="labelDealerScore" runat="server" Text=""> </asp:Label></p>
            </div>
        </div>
        <div class="row">
            <div class="column col-2-1">
                <p class="text"><asp:Label ID="labelResult" runat="server" Text=""></asp:Label></p>
            </div>
       </div>
    </div>
    </div>
    <div class="buttonsDiv">        
        <asp:Button CssClass="button" ID="deal" runat="server" Text="Deal" OnClick="deal_Click" />
        <asp:Button CssClass="button" ID="hit" runat="server" Text="Hit" OnClick="hit_Click" />
        <asp:Button CssClass="button" ID="pass" runat="server" Text="Pass" OnClick="pass_Click" />
        <asp:Button CssClass="button" ID="endGame" runat="server" Text="Restart" OnClick="endGame_Click" />
    </div>
    </form>
    </div>
</body>
</html>

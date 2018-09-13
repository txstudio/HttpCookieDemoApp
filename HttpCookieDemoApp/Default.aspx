<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #description {
            line-height: 30px;
            background: #eee;
            padding-top: 20px;
            padding-bottom: 20px;
        }
    </style>
</head>
<body>
    <div>
        <ul id="description">
            <li>取得 Cookie 資料要使用 Request.Cookie</li>
            <li>設定 Cookie 資料要使用 Response.Cookie.Add( ... )</li>
        </ul>
    </div>
    <form id="form1" runat="server">
        <div>
            Cookie Value : 
            <asp:Literal runat="server" ID="CookieValueLiteral"></asp:Literal>

            <hr />

            Set Cookie Value :
            <asp:TextBox runat="server" ID="CookieValueTextBox"></asp:TextBox>

            <asp:Button runat="server" ID="GenerateCookieButton" 
                        Text="Set Value"
                        OnClick="GenerateCookieButton_Click"/>
        </div>
    </form>
</body>
</html>

<%@ page language="C#" autoeventwireup="true" codebehind="ReqFormAllKeys.aspx.cs" inherits="Request.Form.AllKeys.WebApplication2.pages.ReqFormAllKeys" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="Checkbox1" type="checkbox" name="forumaName0" value="0" />
            <input id="Checkbox2" type="checkbox" name="forumaName1" />
            <input id="Checkbox3" type="checkbox" name="forumaName2" />
            <asp:Button ID="Button1" runat="server" Text="Form Keys" 
                OnClick="Button1_Click" />

            <asp:Button ID="Button2" runat="server" Text="Form Values" 
                OnClick="ButtonValues_Click" />

            <asp:Button ID="Button3" runat="server" Text="Form Elements" 
                OnClick="Button3_Click" />

        </div>
    </form>
</body>
</html>

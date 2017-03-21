<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>Name</div>
        <asp:TextBox ID="tbx_name" runat="server" ValidateRequestMode="Enabled"></asp:TextBox><br />

        <div>Code</div>
        <asp:TextBox ID="tbx_plaintext" runat="server" TextMode="Password"></asp:TextBox><br />

        <div>Password</div>
        <asp:TextBox ID="tbx_passphrase" runat="server" TextMode="Password"></asp:TextBox><br /><br />

        <asp:Button ID="btn_encrypt" runat="server" Text="Encrypt" OnClick="btn_encrypt_Click" /><br /><br />
        <asp:Label ID="lbl_result" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbx_name_for_decrypt" runat="server" ></asp:TextBox>
        <asp:TextBox ID="tbx_passphrase_for_decrypt" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btn_decrypt" runat="server" Text="Decrypt" OnClick="btn_decrypt_Click" />
        <asp:Label ID="lbl_result_after_decrypt" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>

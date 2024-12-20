﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomForm.aspx.cs" Inherits="Validation_Prj.CustomForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" lang="javascript">
        function IsEven(source, args) {
            if (args.Value == "") {
                args.IsValid = false;
                alert("Validation Failed")
            }
            else {
                if ((args.Value > 0) && (args.Value % 2 == 0)) {
                    args.IsValid = true;
                    alert("Validation succeded")
                } else {
                    args.IsValid = false;
                    alert("Validation Failed")
                }
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Enter a Positive Even Number : &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            <asp:TextBox ID="txtnum" runat="server" ></asp:TextBox>
            &nbsp;
            <asp:CustomValidator ID="CustomValidator1" runat="server"
                ErrorMessage="Not a Positive or Even Number" ClientValidationFunction="IsEven" 
                ControlToValidate="txtnum" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" 
                ValidateEmptyText="True"></asp:CustomValidator>
            <br />
            <br />
            <asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click" />
            <br />
            <br/>
            <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>

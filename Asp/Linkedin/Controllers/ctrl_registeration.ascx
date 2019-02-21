<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_registeration.ascx.cs" Inherits="WebApplication2.controls.ctrl_registeration" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>login</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" type="text/css" media="screen" href="../css/style.css" />
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,500,700" rel="stylesheet" />
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.1/css/all.css" />
</head>
<body>
    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" CreateUserButtonText="agree &amp; join" OnCreatedUser="CreateUserWizard1_CreatedUser1" ContinueDestinationPageUrl="~/Home.aspx">
        <CreateUserButtonStyle CssClass="registe__agree" />
        <WizardSteps>
            <asp:CreateUserWizardStep runat="server">
                <ContentTemplate>
                    <div class="regestration-layout">
                        <div class="registe-header">
                            <div class="registe-header__frow">
                                <h3 class="registe-header__frow__linkedin">linked</h3>
                                <%-- <asp:HyperLink runat="server" ID="test" CssClass="btn btn-primary" Text="Contact Us">--%><%--<i class="fa fa-phone"></i> Contact Us</asp:HyperLink>--%>

                                <i class="fab fa-linkedin registe-header__frow__ilinkedin"></i>
                            </div>
                            <p class="registe-header__pargheader">make the most of your professional life</p>
                        </div>
                        <table class="registe">
                            <tr>
                                <td align="center">&nbsp;</td>

                            </tr>
                            <tr>
                                <td>
                                    <label class="registe__lbl">frist name</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox class="registe__txtfname" ID="UserName" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ForeColor="Red" ToolTip="User Name is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label class="registe__lbl">second name</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox class="registe__txtfname" ID="TextBox1" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ForeColor="Red" ToolTip="User Name is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label class="registe__lbl">email</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox class="registe__email" ID="Email" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email" ErrorMessage="E-mail is required." ForeColor="Red" ToolTip="E-mail is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label class="registe__lbl">password(6 or more characters)</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox class="registe__password" ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ForeColor="Red" ToolTip="Password is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label class="registe__lbl">re-password</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox class="registe__password" ID="ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword" ErrorMessage="Confirm Password is required." ForeColor="Red" ToolTip="Confirm Password is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <td>
                                <asp:TextBox ID="Question" runat="server"></asp:TextBox>
                                <%--  <asp:RequiredFieldValidator ID="QuestionRequired" runat="server" ControlToValidate="Question" ErrorMessage="Security question is required." ForeColor="Red" ToolTip="Security question is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>--%>
                            </td>
                            </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="Answer" runat="server"></asp:TextBox>
                            <%--<asp:RequiredFieldValidator ID="AnswerRequired" runat="server" ControlToValidate="Answer" ErrorMessage="Security answer is required." ForeColor="Red" ToolTip="Security answer is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>--%>
                        </td>
                    </tr>
                            <tr>
                                <td align="center">
                                    <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword" Display="Dynamic" ErrorMessage="The Password and Confirmation Password must match." ValidationGroup="CreateUserWizard1"></asp:CompareValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <p class="registe__parg"><span class="registe__parg__splinks">You agree to the LinkedIn<a class="registe__parg__splinks__links1">User Agreement,</a><a class="registe__parg__splinks__links2"> Privacy Policy</a>and <a class="registe__parg__splinks__links3">Cookie Policy<a></a></span></p>
                                </td>
                            </tr>
                            <tr>
                                <td>

                                    <p class="registe__parg">Already on LinkedIn? <a class="registe__parg__links4">Sign in</a></p>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" style="color: Red;">
                                    <asp:Literal ID="ErrorMessage" runat="server" EnableViewState="False"></asp:Literal>
                                </td>
                            </tr>
                        </table>
                    </div>
                </ContentTemplate>
            </asp:CreateUserWizardStep>
            <asp:CompleteWizardStep runat="server" />
        </WizardSteps>
    </asp:CreateUserWizard>
</body>
</html>



<%--    <div class="regestration-layout">
            <div class="registe-header">
                    <div class="registe-header__frow">
                <h3 class="registe-header__frow__linkedin">
                    &nbsp;</h3>
                <i class="fab fa-linkedin registe-header__frow__ilinkedin"></i>
                </div>
                <p class="registe-header__pargheader" >make the most of your professional life</p>
            </div>
            <form class="registe">
                    <label class="registe__lbl" >frist name</label>
                    <input class="registe__txtfname"  type="text">
                    <label class="registe__lbl" >second name</label>
                    <input class="registe__txtlname"  type="text">
                    <label class="registe__lbl" >email</label>
                    <input class="registe__email"  type="text">
                    <label class="registe__lbl" >password(6 or more characters)</label>
                    <input class="registe__password"  type="text">
                    <p class="registe__parg"><span class="registe__parg__splinks">You agree to the LinkedIn<a class="registe__parg__splinks__links1">User Agreement,</a><a class="registe__parg__splinks__links2"> Privacy Policy</a>and <a class="registe__parg__splinks__links3"> Cookie Policy<a></a></span></p>
                    <input class="registe__agree" value="agree & join"  type="button">
                    <p class="registe__parg">Already on LinkedIn? <a class="registe__parg__links4">Sign in</a></p>
                </form>
                <div class="regestration-layout__registration-footer">
                    <p class="regestration-layout__registration-footer__rfooter">LinkedIn Corporation © 2019 </p>
                    </div>
        </div>--%>
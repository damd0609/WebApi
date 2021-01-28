<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApi.Default" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consumir un servicio Web API con C#</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/site.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
 
</head>
<body>
    <div class="container">
        <!-- La imagen se configura en el archivo site.css -->
        <header class="jumbotron">
            <img src="Images/banner.jpg" />

        </header>
        <main>
            <form id="form1" runat="server">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <table style="width: 100%">
                    <tr>
                        <td style="width:20%"></td>
                        <td style="width:70%"></td>
                        <td style="width:10%"></td>
                    </tr>
                    <tr>
                        <td>
                            <ajaxToolkit:ComboBox ID="ComboBox_Paises" runat="server" OnSelectedIndexChanged="ComboBox_Paises_SelectedIndexChanged" AutoPostBack="True"></ajaxToolkit:ComboBox>
                        </td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                          
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:GridView ID="GridView_Datos" runat="server" Width="100%" AutoGenerateColumns="false" OnSelectedIndexChanged="GridView_Datos_SelectedIndexChanged">
                                    <Columns>
                                        <asp:TemplateField HeaderText="Ciudad" ItemStyle-Width="40%">
                                            <ItemTemplate>
                                                <asp:DropDownList ID="DropDownList_Ciudad" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList_Ciudad_SelectedIndexChanged">
                                                </asp:DropDownList>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Distrito" ItemStyle-Width="40%">
                                            <ItemTemplate>
                                                <asp:DropDownList ID="DropDownList_Distrito" runat="server" AutoPostBack="true" OnSelectedIndexChanged ="DropDownList_Distrito_SelectedIndexChanged" ></asp:DropDownList>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Pasaje" ItemStyle-Width="20%">
                                            <ItemTemplate>
                                                <asp:Label ID="lbl_Pasaje" runat="server"></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                        </td>
                        <td></td>
                    </tr>
                </table>
                        <!-- fin de la fila (Row) -->
                    </ContentTemplate>
                </asp:UpdatePanel>
            </form>
        </main>
    </div>
</body>
</html>


<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/admin/AdminMaster.Master" EnableEventValidation="false" CodeBehind="InquiryList.aspx.cs" Inherits="apcc.admin.InquiryList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/AdminStyle.css" rel="stylesheet" />
    <script src="plugins/jQuery/jquery-2.2.3.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#grvInquiry").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable({
                "order": [[0, "desc"]]
            });
        });

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" class="container">
    <div class="box box-info">
        <div class="row">
            <div class="box-header with-border">
                <div class="col-lg-12">
                    <div class="col-lg-6">
                        <h3 class="box-title">Inquiry List</h3>
                    </div>
                    <div class="col-lg-3">
                    </div>
                    <div class="col-lg-3 ">
                        <asp:Button ID="btnAddInquiry" CssClass="btn btn-primary right" Text="Add Inquiry" runat="server" OnClick="btnAddInquiry_Click" />
                    </div>
                </div>
            </div>
        </div>
        <div>
            <div class="box-body">
                <div class="table-responsive">
                    <asp:GridView ID="grvInquiry" runat="server" ClientIDMode="Static" AutoGenerateColumns="false">
                        <Columns>
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="Inquiry Id">
                                <ItemTemplate>
                                    <asp:Label ID="lblCourseId" runat="server"
                                        Text='<%# Eval("Id")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="First Name">
                                <ItemTemplate>
                                    <asp:Label ID="lblfname" runat="server"
                                        Text='<%# Eval("fname")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="Last Name">
                                <ItemTemplate>
                                    <asp:Label ID="lbllname" runat="server"
                                        Text='<%# Eval("lname")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="Course Name">
                                <ItemTemplate>
                                    <%# Convert.ToString(Eval("CourseName")).TrimStart(',')%>
                                </ItemTemplate>

                            </asp:TemplateField>
                              <asp:TemplateField ItemStyle-Width="30px" HeaderText="Inquiry Date">
                                <ItemTemplate>
                                    <%# Convert.ToString(Eval("InquiryDate_S")).TrimStart(',')%>
                                </ItemTemplate>

                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="Mobile">
                                <ItemTemplate>
                                    <asp:Label ID="lblMobile" runat="server"
                                        Text='<%# Eval("Mobile")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="bntEdit" runat="server" class="btn btn-sm btn-primary"
                                        CommandArgument='<%# Eval("ID")%>'
                                        Text="Edit" OnClick="bntEdit_Click"></asp:Button>
                                     <asp:Button ID="bntDelete" runat="server" class="btn btn-sm btn-danger"
                                        CommandArgument='<%# Eval("ID")%>'
                                        OnClientClick="return confirm('Do you want to delete?')"
                                        Text="Delete" OnClick="bntDelete_Click"></asp:Button>
                                </ItemTemplate>

                            </asp:TemplateField>

                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#grvInquiry").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
</asp:Content>

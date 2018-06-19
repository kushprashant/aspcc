<%@ Page Title="Course" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="CourseList.aspx.cs" Inherits="apcc.admin.CourseList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" class="container">
    <div class="box box-info">

        <div class="row">
            <div class="box-header with-border">
                <div class="col-lg-12">
                    <div class="col-lg-6">
                        <h3 class="box-title">Course List</h3>
                    </div>
                    <div class="col-lg-3">
                    </div>
                    <div class="col-lg-3 ">
                        <asp:Button ID="btnAddCourse" CssClass="btn btn-primary right" Text="Add Course" runat="server" OnClick="btnAddCourse_Click" />
                    </div>
                </div>

            </div>

        </div>
        <div>
            <div class="box-body">
                <div class="table-responsive">
                    <asp:GridView ID="grvCourser" runat="server" ClientIDMode="Static" AutoGenerateColumns="false">
                        <Columns>
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="Course Id">
                                <ItemTemplate>
                                    <asp:Label ID="lblCourseId" runat="server"
                                        Text='<%# Eval("id")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="Course Name">
                                <ItemTemplate>
                                    <asp:Label ID="lblCourseName" runat="server"
                                        Text='<%# Eval("CourseName")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="Fees">
                                <ItemTemplate>
                                    <asp:Label ID="lblFees" runat="server"
                                        Text='<%# Eval("Fee")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="Duration">
                                <ItemTemplate>
                                    <asp:Label ID="lblDuration" runat="server"
                                        Text='<%# Eval("Duration")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="Active">
                                <ItemTemplate>
                                    <asp:Label ID="lblActive" runat="server"
                                        Text='<%# Eval("ActtiveText")%>'></asp:Label>
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
        $("#grvCourser").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
    });
</script>
</asp:Content>


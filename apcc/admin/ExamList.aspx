<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ExamList.aspx.cs" Inherits="apcc.admin.Exams.ExamList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box box-info">

        <div class="row">
            <div class="box-header with-border">
                <div class="col-lg-12">
                    <div class="col-lg-2">
                        <h3 class="box-title">Exam List</h3>
                    </div>
                    <div class="col-lg-6">
                        <button type="button" class="btn" data-toggle="modal" data-target="#myModal">Copy Qestion</button>
                    </div>
                    <div class="col-lg-3">
                        <asp:Button ID="btnAddExam" CssClass="btn btn-primary right" Text="Add Exam" runat="server" OnClick="btnAddExam_Click" />
                    </div>
                </div>

            </div>

        </div>
        <div>
            <div class="box-body">
                <div class="table-responsive">
                    <asp:GridView ID="grvExam" runat="server" ClientIDMode="Static" AutoGenerateColumns="false">
                        <Columns>
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="Course Id">
                                <ItemTemplate>
                                    <asp:Label ID="lblExamId" runat="server"
                                        Text='<%# Eval("Id")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="Exam Name">
                                <ItemTemplate>
                                    <asp:Label ID="lblExamName" runat="server"
                                        Text='<%# Eval("Name")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="No Of Question">
                                <ItemTemplate>
                                    <asp:Label ID="lblnoofQestion" runat="server"
                                        Text='<%# Eval("noofQestion")%>'></asp:Label>
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
                                        CommandArgument='<%# Eval("Id")%>'
                                        Text="Edit" OnClick="bntEdit_Click"></asp:Button>
                                    <asp:Button ID="btnQuestion" runat="server" class="btn btn-sm btn-primary"
                                        CommandArgument='<%# Eval("Id")%>'
                                        Text="Question" OnClick="btnQuestion_Click"></asp:Button>
                                    <asp:Button ID="bntDelete" runat="server" class="btn btn-sm btn-danger"
                                        CommandArgument='<%# Eval("Id")%>'
                                        OnClientClick="return confirm('Do you want to delete?')"
                                        Text="Delete" OnClick="bntDelete_Click"></asp:Button>
                                </ItemTemplate>

                            </asp:TemplateField>

                        </Columns>
                    </asp:GridView>

                </div>
            </div>
        </div>

        <div id="myModal" class="modal fade" role="dialog">
            <div class="modal-dialog">

                <!-- Modal content-->
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Exam Question Copy</h4>
                    </div>
                    <div class="modal-body">
                        <div class="form-group row">
                            <div class="col-sm-12">
                                <div class="col-sm-3">
                                    <label for="usr">From Exam</label>
                                </div>
                                <div class="col-sm-6">
                                    <asp:DropDownList ID="ddlExamFrom" ClientIDMode="Static" class="form-control" SelectionMode="Multiple" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="form-group row">
                            <div class="col-sm-12">
                                <div class="col-sm-3">
                                    <label for="usr">To Exam</label>
                                </div>
                                <div class="col-sm-6">
                                    <asp:DropDownList ID="ddlExamTo" ClientIDMode="Static" class="form-control" SelectionMode="Multiple" runat="server"></asp:DropDownList>
                                </div>

                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <div class="col-sm-3">
                            <asp:Button Text="Submit" id="btnExamCopy" CssClass="btn btn-primary right" OnClick="btnExamCopy_Click" runat="server" />
                        </div>
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>

            </div>
        </div>
    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            $("#grvExam").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ExamQuestioList.aspx.cs" Inherits="apcc.admin.ExamQuestioList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box box-info">

        <div class="row">
            <div class="box-header with-border">
                <div class="col-lg-12">
                    <div class="col-lg-6">
                        <h3 class="box-title" id="headExam" runat="server">Exam Name Question List</h3>
                    </div>
                     <div class="col-lg-3">
                         <asp:Button Text="Print" id="btnPrint" CssClass="btn btn-primary right"  OnClientClick="target ='_blank';" OnClick="btnPrint_Click" runat="server" />
                         </div>
                    <div class="col-lg-3 ">
                        <asp:Button ID="btnAddQuestion" CssClass="btn btn-primary" Text="Add Question Exam" runat="server" OnClick="btnAddQuestion_Click" />
               
                          <asp:Button ID="btnBack" CssClass="btn btn-default" Text="Back" runat="server" OnClick="btnBack_Click" />
                    </div>
                </div>

            </div>

        </div>
        <div>
            <div class="box-body">
                <div class="table-responsive">
                    <asp:GridView ID="grvQuestion" runat="server" ClientIDMode="Static" AutoGenerateColumns="false">
                        <Columns>
                            <asp:TemplateField ItemStyle-Width="10px" HeaderText="Question Id">
                                <ItemTemplate>
                                    <asp:Label ID="lblQuestionId" runat="server"
                                        Text='<%# Eval("Id")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="Question">
                                <ItemTemplate>
                                    <asp:Label ID="lblQuestionName" runat="server"
                                        Text='<%# Eval("Question")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="bntEdit" runat="server" class="btn btn-sm btn-primary"
                                        CommandArgument='<%# Eval("ExamId")+"&"+ Eval("Id")%>'
                                        Text="Edit" OnClick="bntEdit_Click"></asp:Button>
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
    </div>

     <script type="text/javascript">
    $(document).ready(function () {
        $("#grvQuestion").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable({
            "columnDefs": [
        { "width": "10%", "targets": 0 },
            { "width": "20%", "targets": 2 }
            ]
        });
    });
</script>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Students/StudentMaster.Master" AutoEventWireup="true" CodeBehind="StudentResult.aspx.cs" Inherits="apcc.Students.StudentResult" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="box box-info">
        <div class="row">
            <div class="box-header with-border">
                <div class="col-lg-12">
                    <div class="col-lg-4">
                        <h3 class="box-title">
                            <asp:Label Text="Exam Name" ID="lblExamName" runat="server" /></h3>
                    </div>
                     <div class="col-lg-4">
                        <h3 class="box-title">
                            <asp:Label Text="Date" ID="lblDate" runat="server" /></h3>
                    </div>
                    <div class="col-lg-4">
                        <h3 class="box-title">
                            <asp:Label Text="score" ID="lblScore" runat="server" /></h3>
                    </div>
                </div>
            </div>
        </div>
        <div>
            <div class="box-body">
                <div class="table-responsive">
                    <asp:GridView ID="grvStudentExamResult" runat="server" ClientIDMode="Static" AutoGenerateColumns="false" ShowHeaderWhenEmpty="True" EmptyDataText="No records Found">
                        <Columns>
                            <asp:TemplateField HeaderText="No." ItemStyle-Width="5px">
                                <ItemTemplate>
                                    <%# Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="400px" HeaderText="Question">
                                <ItemTemplate>
                                    <asp:Label ID="lblQuestion" runat="server"
                                        Text='<%# Eval("Question")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                           <%-- <asp:TemplateField ItemStyle-Width="20px" HeaderText="Option 1">
                                <ItemTemplate>
                                    <asp:Label ID="lblOption1" runat="server"
                                        Text='<%# Eval("Option1")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="20px" HeaderText="Option 2">
                                <ItemTemplate>
                                    <asp:Label ID="lblOption2" runat="server"
                                        Text='<%# Eval("Option2")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="20px" HeaderText="Option 3">
                                <ItemTemplate>
                                    <asp:Label ID="lblOption3" runat="server"
                                        Text='<%# Eval("Option3")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="20px" HeaderText="Option 4">
                                <ItemTemplate>
                                    <asp:Label ID="lblnOption4" runat="server"
                                        Text='<%# Eval("Option4")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>--%>
                            <asp:TemplateField HeaderStyle-HorizontalAlign="Center" ItemStyle-Width="20px" HeaderText="Correct Ans">
                                <ItemTemplate>
                                    <asp:Label ID="lblCorrectAns" runat="server"
                                        Text='<%# Eval("CorrectAns")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderStyle-HorizontalAlign="Center" ItemStyle-Width="20px" HeaderText="Given Answer">
                                <ItemTemplate>
                                    <asp:Label ID="lblAnswer" runat="server"
                                        Text='<%# Eval("Answer")%>'></asp:Label>
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
            $("#grvStudentExamResult").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
    <asp:HiddenField ID="hdtotalScore" Value="0" runat="server" />
</asp:Content>

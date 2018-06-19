<%@ Page Title="DashBoard" Language="C#" MasterPageFile="~/Students/StudentMaster.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="apcc.Students.DashBoard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     
    <div class="box box-info">
        <div class="row">
            <div class="box-header with-border">
                <div class="col-lg-12">
                    <div class="col-lg-6">
                        <h3 class="box-title">Exam List</h3>
                    </div>
                </div>
            </div>
        </div>
         <div>
            <div class="box-body">
                <div class="table-responsive">
                    <asp:GridView ID="grvStudentExam" runat="server" ClientIDMode="Static" AutoGenerateColumns="false" ShowHeaderWhenEmpty="True" EmptyDataText="No records Found">
                        <Columns>
                            <asp:TemplateField HeaderText="No." HeaderStyle-Width="5px"  ItemStyle-Width="5px">
                                <ItemTemplate>
                                    <%# Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                          <asp:TemplateField ItemStyle-Width="250px" HeaderText="Exam Name">
                                <ItemTemplate>
                                    <asp:Label ID="lblExamName" runat="server"
                                        Text='<%# Eval("Name")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderStyle-Width="30px" ItemStyle-Width="5px" HeaderText="No Of Question">
                                <ItemTemplate>
                                    <asp:Label ID="lblnoofQestion" runat="server"
                                        Text='<%# Eval("noofQestion")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="bntAttemtpt" runat="server" class="btn btn-sm btn-primary"
                                        CommandArgument='<%# Eval("Id")%>'
                                        Text="Attempt" OnClick="bntAttemtpt_Click"></asp:Button>
                                       <asp:Button ID="btnView" runat="server" class="btn btn-sm btn-primary"
                                        CommandArgument='<%# Eval("Id")%>'
                                        Text="View Result" OnClick="btnView_Click"></asp:Button>
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
        $("#grvStudentExam").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
    });
</script>
</asp:Content>

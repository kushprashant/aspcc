<%@ Page Title="" Language="C#" MasterPageFile="~/Students/StudentMaster.Master" AutoEventWireup="true" CodeBehind="ViewResult.aspx.cs" Inherits="apcc.Students.ViewResult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <div class="box box-info">
        <div class="row">
            <div class="box-header with-border">
                <div class="col-lg-12">
                    <div class="col-lg-6">
                        <h3 class="box-title">
                            <asp:Label Text="Exam List" ID="lblExamName"  runat="server" /></h3>
                    </div>
                </div>
            </div>
        </div>
         <div>
            <div class="box-body">
                <div class="table-responsive">
                    <asp:GridView ID="grvviewResult" runat="server" ClientIDMode="Static" AutoGenerateColumns="false" ShowHeaderWhenEmpty="True" EmptyDataText="No records Found">
                        <Columns>
                            <asp:TemplateField HeaderText="No." HeaderStyle-Width="5px"  ItemStyle-Width="5px">
                                <ItemTemplate>
                                    <%# Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                              <asp:TemplateField ItemStyle-Width="250px" HeaderText="Course Name">
                                <ItemTemplate>
                                    <asp:Label ID="lblCourseName" runat="server"
                                        Text='<%# Eval("CourseName")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField> 
                          <asp:TemplateField ItemStyle-Width="250px" HeaderText="Exam Name">
                                <ItemTemplate>
                                    <asp:Label ID="lblExamName" runat="server"
                                        Text='<%# Eval("ExamName")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                               <asp:TemplateField HeaderStyle-Width="30px" ItemStyle-Width="5px" HeaderText="Total Marks">
                                <ItemTemplate>
                                    <asp:Label ID="lblTotalmarks" runat="server"
                                        Text='<%# Eval("Totalmarks")%>'></asp:Label>
                                    /
                                     <asp:Label ID="lblnoofQestion" runat="server"
                                        Text='<%# Eval("noofQestion")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                    <%--        <asp:TemplateField HeaderStyle-Width="30px" ItemStyle-Width="5px" HeaderText="No Of Question">
                                <ItemTemplate>
                                    <asp:Label ID="lblnoofQestion" runat="server"
                                        Text='<%# Eval("noofQestion")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>--%>
                            <asp:TemplateField HeaderStyle-Width="30px" ItemStyle-Width="5px" HeaderText="Exam Date">
                                <ItemTemplate>
                                    <asp:Label ID="lblModDt" runat="server"
                                        Text='<%# Eval("ModDt")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="bntDetails" runat="server" class="btn btn-sm btn-primary"
                                        CommandArgument='<%# Eval("StudentExamId")%>'
                                        Text="Details" OnClick="bntDetails_Click"></asp:Button>
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
        $("#grvviewResult").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
    });
</script>
</asp:Content>

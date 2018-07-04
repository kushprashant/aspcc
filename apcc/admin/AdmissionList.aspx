<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMaster.Master"  EnableEventValidation="false"  AutoEventWireup="true" CodeBehind="AdmissionList.aspx.cs" Inherits="apcc.admin.AdmissionList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box box-info">
        <div class="row">
            <div class="box-header with-border">
                <div class="col-lg-12">
                    <div class="col-lg-6">
                        <h3 class="box-title">Admission List</h3>
                    </div>
                    <div class="col-lg-3">
                    </div>
                    <div class="col-lg-3 ">
                        <asp:Button ID="btnAddAdmission" CssClass="btn btn-primary right" Text="Add Admission" runat="server" OnClick="btnAddAdmission_Click" />
                    </div>
                </div>
            </div>
        </div>
        <div class="box-body">
                <div class="table-responsive">
                    <asp:GridView ID="grvAdmission" runat="server" ClientIDMode="Static" AutoGenerateColumns="false">
                        <Columns>
                            <asp:TemplateField ItemStyle-Width="10px" HeaderText="Id">
                                <ItemTemplate>
                                    <asp:Label ID="lblAdmissionId" runat="server"
                                        Text='<%# Eval("Id")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="10px" HeaderText="Admission No">
                                <ItemTemplate>
                                    <asp:Label ID="lblAdmissionNo" runat="server"
                                        Text='<%# Eval("AdmissionNo")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField ItemStyle-Width="10px" HeaderText="Reg No">
                                <ItemTemplate>
                                    <asp:Label ID="lblRegNo" runat="server"
                                        Text='<%# Eval("RegNo")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField ItemStyle-Width="10px" HeaderText="Join Date">
                                <ItemTemplate>
                                    <asp:Label ID="lblJoinDate" runat="server"
                                        Text='<%# Eval("JoinDate")%>'></asp:Label>
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
                                    <asp:Label ID="lblLname" runat="server"
                                        Text='<%# Eval("Lname")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="10px" HeaderText="Mobile Personal">
                                <ItemTemplate>
                                    <asp:Label ID="lblMobileP" runat="server"
                                        Text='<%# Eval("MobileP")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                              <asp:TemplateField ItemStyle-Width="30px" HeaderText="Mobile Home">
                                <ItemTemplate>
                                    <asp:Label ID="lblMobileH" runat="server"
                                        Text='<%# Eval("MobileH")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="Course Name">
                                <ItemTemplate>
                                    <%# Convert.ToString(Eval("CourseName")).TrimStart(',')%>
                                </ItemTemplate>
                            </asp:TemplateField>
                                <asp:TemplateField ItemStyle-Width="30px" HeaderText="Fees Remain">
                                <ItemTemplate>
                                    <asp:Label ID="lblFeesRemain" runat="server"
                                        Text='<%# Eval("FeesRemain")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="150px" HeaderStyle-Width="85px" HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="bntEdit" runat="server" class="btn btn-sm btn-primary"
                                        CommandArgument='<%# Eval("ID")%>'
                                        Text="Edit" OnClick="bntEdit_Click"></asp:Button>
                                    <asp:Button ID="btnprint" runat="server" class="btn btn-sm btn-primary"
                                        CommandArgument='<%# Eval("ID")%>'
                                        Text="Print" OnClick="btnprint_Click"></asp:Button>
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
     <script type="text/javascript">
    $(document).ready(function () {
        $("#grvAdmission").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable({
            "order": [[0, "desc"]]
        });
    });
</script>
</asp:Content>

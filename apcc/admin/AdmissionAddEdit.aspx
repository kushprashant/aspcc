<%@ Page Title="Admission" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="AdmissionAddEdit.aspx.cs" Inherits="apcc.admin.AdmissionAddEdit" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" class="container">
    
    <div class="box box-info">
        <div class="row">
            <div class="box-header with-border">
                <div class="col-sm-12">
                    <div class="col-sm-3">
                        <h3 runat="server" id="lblHead" class="box-title margingleft10">
                            <label for="usr">Admission Add</label>
                        </h3>
                    </div>
                    <div class="col-sm-3">
                        
                    </div>
                   
                </div>

            </div>
        </div>

        <div class="box-body">
            <div class="form-group row" runat="server" id="DivError" visible="false">
                <div class="col-sm-12">
                    <div class="alert alert-danger alert-dismissible">
                        <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
                        <h4><i class="icon fa fa-ban"></i>Error!</h4>
                        <asp:Label Text="Please Try after some Time." ID="lblErrorMsg" runat="server" />
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <%-- <div class="col-sm-2">
                        <label for="usr">No:</label>
                    </div>--%>
                    <div class="col-sm-3">
                        <asp:TextBox ID="txtAdmissionNo" class="form-control" onkeyup="numberOnly(this)" MaxLength="10" runat="server" placeholder="Admission No"></asp:TextBox>
                    </div>

                    <div class="col-sm-3">
                        <asp:TextBox ID="txtAdmissionDate" class="form-control clsdatepicker" onkeyup="numberOnly(this)" MaxLength="10" runat="server" placeholder="Admission Date"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-4">
                        <asp:TextBox ID="txtFirstName" ClientIDMode="Static" class="form-control" runat="server" placeholder="First name"></asp:TextBox>
                        <%-- <asp:RequiredFieldValidator CssClass="reqValidate" ErrorMessage="Required" ControlToValidate="txtFirstName" runat="server" />--%>
                    </div>
                    <div class="col-sm-4">
                        <asp:TextBox ID="txtMiddelName" ClientIDMode="Static" class="form-control" runat="server" placeholder="Middle name"></asp:TextBox>
                        <%-- <asp:RequiredFieldValidator CssClass="reqValidate" ErrorMessage="Required" ControlToValidate="txtMiddelName" runat="server" />--%>
                    </div>
                    <div class="col-sm-4">
                        <asp:TextBox ID="txtLastName" ClientIDMode="Static" class="form-control" runat="server" placeholder="Last name"></asp:TextBox>
                        <%-- <asp:RequiredFieldValidator CssClass="reqValidate" ErrorMessage="Required" ControlToValidate="txtLastName" runat="server" />--%>
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Adress:</label>
                    </div>
                    <div class="col-sm-6">
                        <textarea id="txtAdress" class="form-control" runat="server"></textarea>
                        <%-- <asp:RequiredFieldValidator CssClass="reqValidate" ErrorMessage="Required" ControlToValidate="txtAdress" runat="server" />--%>
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Mobile(H):</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox ID="txtMobileH" class="form-control" onkeyup="numberOnly(this)" MaxLength="10" runat="server" placeholder="Mobile Home"></asp:TextBox>
                    </div>
                    <div class="col-sm-2">
                        <label for="usr">Mobile(F):</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox ID="txtMobileF" class="form-control" onkeyup="numberOnly(this)" MaxLength="10" runat="server" placeholder="Mobile Father"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Mobile(P):</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox ID="txtMobileP" ClientIDMode="Static" class="form-control" onkeyup="numberOnly(this)" MaxLength="10" runat="server" placeholder="Mobile Pesonal"></asp:TextBox>
                    </div>
                    <div class="col-sm-2">
                        <label for="usr">Email:</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox ID="txtEmail" ClientIDMode="Static" class="form-control" runat="server" placeholder="Email Id"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Area:</label>
                    </div>
                    <div class="col-sm-6">
                        <asp:DropDownList ID="ddlArea" class="form-control" runat="server"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Qualification:</label>
                    </div>
                    <div class="col-sm-6">
                        <asp:TextBox ID="txtQualification" class="form-control" runat="server" placeholder="Qualification"></asp:TextBox>
                    </div>

                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Stream:</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList ID="ddlStream" class="form-control" runat="server">
                            <asp:ListItem Value="0">Select Stream </asp:ListItem>
                            <asp:ListItem Value="1">Arts </asp:ListItem>
                            <asp:ListItem Value="2">Commerce </asp:ListItem>
                            <asp:ListItem Value="3">Scince </asp:ListItem>
                            <asp:ListItem Value="4">Other </asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-sm-2">
                        <label for="usr">Occupation:</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList ID="ddloccupation" class="form-control" runat="server">
                            <asp:ListItem Value="0">Select Occupation </asp:ListItem>
                            <asp:ListItem Value="1">Student </asp:ListItem>
                            <asp:ListItem Value="2">Job </asp:ListItem>
                            <asp:ListItem Value="2">Bussiness </asp:ListItem>
                            <asp:ListItem Value="4">Other </asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Course:</label>
                    </div>
                    <div class="col-sm-6">
                        <asp:ListBox ID="ddlCourse" SelectionMode="Multiple" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="ddlCourse_SelectedIndexChanged" class="form-control" runat="server"></asp:ListBox>
                        <%--<asp:Button id="btncourseSelect" style="display:none;"  OnClick="ddlCourse_SelectedIndexChanged" runat="server" />--%>
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">School Name:</label>
                    </div>
                    <div class="col-sm-6">
                        <asp:TextBox ID="txtSchoolName" class="form-control" runat="server" placeholder="School Name"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Birth Date:</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox ID="txtBirthDate" class="form-control clsdatepickerAge" ClientIDMode="Static" runat="server" placeholder="Birth Date"></asp:TextBox>
                    </div>
                    <div class="col-sm-2">
                        <label for="usr">Age:</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox ID="txtAge" Enabled="false" class="form-control" ClientIDMode="Static" runat="server" placeholder="Age"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Prefer Time:</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox runat="server" ID="txtFromTime" ClientIDMode="Static" class="form-control timepicker" />
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox runat="server" ID="txtToTime" ClientIDMode="Static" class="form-control timepicker" />
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Remark:</label>
                    </div>
                    <div class="col-sm-3">
                        <textarea id="txtRemark" class="form-control" runat="server"></textarea>
                    </div>
                    <div class="col-sm-2">
                        <label for="usr">Reg. No:</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox ID="txtRegNo" class="form-control " onkeyup="numberOnly(this)" MaxLength="10" runat="server" placeholder="Reg. No"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Total Fees:</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox runat="server" ID="txtTotalFees" ClientIDMode="Static" onkeyup="numberOnly(this);" class="form-control" />
                    </div>
                    <div class="col-sm-3">
                        <asp:Button Text="Add Installment" ID="btnAddInstallment" runat="server" OnClick="btnAddInstallment_Click" class="btn  btn-primary" />
                        <asp:TextBox runat="server" ID="txtNoofInstallment" onkeyup="numberOnly(this);" AutoPostBack="true" class="form-control hideControl" OnTextChanged="txtNoofInstallment_TextChanged" />
                    </div>
                     <div class="col-sm-3">
                         <button type="button" id="btnPrintPopUp" class="btn btn-primary" data-toggle="modal" data-target="#myModal">Print Recipts</button>
                    </div>
                    <%-- <div class="col-sm-3">
                         <asp:Button Text="Delete Installment" ID="delInstallment" runat="server" OnClick="delInstallment_Click" class="btn  btn-primary" />
                    </div>--%>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">DisCount:</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox runat="server" value="0" ID="txtDisCount" ClientIDMode="Static" onkeyup="numberOnly(this);" onblur="setNetFees()" class="form-control" />
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Net Fees:</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox runat="server" ID="txtNetFees" ClientIDMode="Static" onkeyup="numberOnly(this);" class="form-control" />
                    </div>
                </div>
            </div>
            <%-- <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Installment 1:</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox runat="server" ID="txtdateInstallment1" class="form-control" placeholder="Installment 1 Date" />
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox runat="server" ID="txtrdInstallment1" class="form-control" placeholder="Installment 1 Rs" />
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Installment 2:</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox runat="server" ID="txtdateInstallment2" class="form-control" placeholder="Installment 2 Date" />
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox runat="server" ID="txtrdInstallment2" class="form-control" placeholder="Installment 2 Rs" />
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Installment 3:</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox runat="server" ID="txtdateInstallment3" class="form-control" placeholder="Installment 3 Date" />
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox runat="server" ID="txtrdInstallment3" class="form-control" placeholder="Installment 3 Rs" />
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Installment 4:</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox runat="server" ID="txtdateInstallment4" class="form-control" placeholder="Installment 4 Date" />
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox runat="server" ID="txtrdInstallment4" class="form-control" placeholder="Installment 4 Rs" />
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Installment 5:</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox runat="server" ID="txtdateInstallment5" class="form-control" placeholder="Installment 5 Date" />
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox runat="server" ID="txtrdInstallment5" class="form-control" placeholder="Installment 5 Rs" />
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Installment 6:</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox runat="server" ID="txtdateInstallment6" class="form-control" placeholder="Installment 6 Date" />
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox runat="server" ID="txtrdInstallment6" class="form-control" placeholder="Installment 6 Rs" />
                    </div>
                </div>
            </div>--%>

            <asp:Panel ID="pnlInstallmentBoxes" runat="server">
            </asp:Panel>
            <div class="box-footer">
                <div class="col-sm-12">
                    <div class="col-sm-4">
                        <hr class="hrblack" />
                        <label for="usr" style="margin-left: 90px">Signature of Parents</label>
                    </div>
                    <div class="col-sm-4">
                    </div>
                    <div class="col-sm-4">
                        <hr class="hrblack" />
                        <label for="usr" style="margin-left: 90px">Signature of Applicant</label>
                    </div>
                </div>
                <br />
                <div class="col-sm-12">
                    <label for="usr">N.B : In case cancellation of admission of any course fee will not be given back.</label>
                    <br />
                    <label for="usr">Subject to Ahmadabad Jurisdiction.</label>
                </div>
            </div>
            <%-- <div class="box-footer">
                <div class="col-sm-12">
                    <div class="col-sm-4">
                        <label for="usr"> Signature of Parents</label>
                    </div>
                    <div class="col-sm-4">
                       
                    </div>
                    <div class="col-sm-4">
                        <label for="usr"> Signature of Applicant</label>
                    </div>
                </div>
            </div>--%>
            <div class="box-footer">
                <div class="col-sm-12">
                    <div class="col-sm-4">
                    </div>
                    <div class="col-sm-4">
                        <asp:Button ID="btnsave" CssClass="btn  btn-primary" runat="server" OnClientClick="return validate()" class="btn btn-primary" Text="Save" OnClick="btnsave_Click" />
                        <asp:Button ID="btncancle" runat="server" class="btn btn-default" Text="Cance" OnClick="btncancle_Click" />
                    </div>
                    <div class="col-sm-4">
                    </div>
                </div>
            </div>
        </div>
           <div id="myModal" class="modal fade" role="dialog">
            <div class="modal-dialog">

                <!-- Modal content-->
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Print Recipt</h4>
                    </div>
                    <div class="modal-body">
                        <div class="form-group row">
                            <div class="col-sm-12">
                                <div class="col-sm-3">
                                    <label for="usr">Select Installment</label>
                                </div>
                                <div class="col-sm-6">
                                    <asp:DropDownList ID="ddlInstallment" ClientIDMode="Static" class="form-control" SelectionMode="Multiple" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <div class="col-sm-3">
                            <asp:Button Text="Print" id="btnPrint" CssClass="btn btn-primary right"  OnClientClick="target ='_blank';" OnClick="btnPrint_Click" runat="server" />
                        </div>
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>
             
            </div>
        </div>
        <div>

        
         
            </div>
    </div>
    <script type="text/javascript">

        $(document).ready(function () {
            $('#txtFromTime').timepicker();
            $('#txtToTime').timepicker();
            $('.clsdatepicker').datepicker({
                dateFormat: 'dd-mm-yy',
                changeMonth: true,
                changeYear: true,
                yearRange: "-100:+0"
            });

            $('.clsdatepickerAge').datepicker({
                dateFormat: 'dd-mm-yy',
                changeMonth: true,
                changeYear: true,
                yearRange: "-100:+0",
                onSelect: function () {
                    var age = getage($(this).change().val());
                    $("#txtAge").val(age);
                }
            });
            $('[id*=ddlCourse]').multiselect({
                includeSelectAllOption: true,
                buttonWidth: '100%',
                numberDisplayed: 5,
                onDropdownHide: function (event) {
                    $('#ContentPlaceHolder1_btncourseSelect').click();
                }
            });
        });

        function setNetFees() {
            var discout = $("#txtDisCount").val();
            var totalfess = $("#txtTotalFees").val();
            // var dicamt = totalfess * discout / 100;
            var netFess = totalfess - discout;
            $("#txtNetFees").val(netFess);
        }

        function validate() {
            var type = 'error';
            var msg = "";
            var title = 'Required';

            var fistname = $("#txtFirstName").val().trim();
            var MiddelName = $("#txtMiddelName").val().trim();
            var LastName = $("#txtLastName").val().trim();
            var MobileP = $("#txtMobileP").val().trim();
            var Course = $("#ddlCourse").val();
            var BirthDate = $("#txtBirthDate").val().trim();
            var FromTime = $("#txtFromTime").val().trim();
            var ToTime = $("#txtToTime").val().trim();
            var TotalFees = $("#txtTotalFees").val().trim();
            var NetFees = $("#txtNetFees").val().trim();

            if (fistname == "") {
                msg = "First Name ";
                $("#txtFirstName").css("border-color", "red");
            }
            if (MiddelName == "") {
                msg += "<br> Middel Name";
                $("#txtMiddelName").css("border-color", "red");
            }
            if (LastName == "") {
                msg += "<br> Last Name";
                $("#txtLastName").css("border-color", "red");
            }
            if (MobileP == "") {
                //msg += "<br> Mobile Personal";
                //$("#txtMobileP").css("border-color", "red");
            }
            if (Course == "0" || Course == "null" || Course == undefined || Course == null) {
                msg += "<br>  Course";
                Course = $("#ddlCourse").css("border-color", "red");
            }
            if (BirthDate == "") {
                msg += "<br> BirthDate";
                $("#txtBirthDate").css("border-color", "red");
            }
            if (FromTime == "") {
                msg += "<br> From Time";
                $("#txtFromTime").css("border-color", "red");
            }
            if (ToTime == "") {
                msg += "<br>  To Time";
                $("#txtToTime").css("border-color", "red");
            }
            if (TotalFees == "") {
                msg += "<br> Total Fees";
                $("#txtTotalFees").css("border-color", "red");
            }
            if (NetFees == "") {
                msg += "<br> Net Fees";
                $("#txtNetFees").css("border-color", "red");
            }


            if (msg != "") {
                showNofication(type, title, msg);
                return false;
            } else {
                return true;
            }


        }

        function setFocuse(id) {
            $("#" + id).focus();
        }


    </script>
   
</asp:Content>

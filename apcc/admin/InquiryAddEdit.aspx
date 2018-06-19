<%@ Page Title="Inquiry" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="InquiryAddEdit.aspx.cs" Inherits="apcc.admin.InquiryAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box box-info">
        <div class="box-header with-border">
            <h3 class="box-title" runat="server" id="lblHead">Inquiry Add</h3>
        </div>
        <div class="form-group row">
            <div class="col-sm-12">
                <asp:Label Text="" ID="lblSuccessMsg" runat="server" CssClass="sucess" />
                <asp:Label Text="" ID="lblErrorMsg" runat="server" />
            </div>
        </div>
           <div class="form-group row">
            <div class="col-sm-12">
                <div class="col-sm-2">
                  Inquiry Date
                </div>
                <div class="col-sm-6">
                    <asp:TextBox ID="txtInquiryDate" Enabled="false" class="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-12">
                <div class="col-sm-2">
                    First Name 
                </div>
                <div class="col-sm-6">
                    <asp:TextBox ID="txtFirstName" class="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-12">
                <div class="col-sm-2">
                    Last Name 
                </div>
                <div class="col-sm-6">
                    <asp:TextBox ID="txtLastName" class="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-12">
                <div class="col-sm-2">
                    Course 
                </div>
                <div class="col-sm-6">
                    <asp:ListBox  ID="ddlCourse" ClientIDMode="Static" class="form-control" SelectionMode="Multiple" runat="server"></asp:ListBox>
                </div>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-12">
                <div class="col-sm-2">
                    Email
                </div>
                <div class="col-sm-6">
                    <asp:TextBox ID="txtEmail" class="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-12">
                <div class="col-sm-2">
                    Mobile
                </div>
                <div class="col-sm-6">
                    <asp:TextBox ID="txtMobile" class="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-12">
                <div class="col-sm-2">
                    Adress
                </div>
                <div class="col-sm-6">
                    <textarea id="txtAddress" class="form-control" runat="server"></textarea>
                </div>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-12">
                <div class="col-sm-2">
                    Area
                </div>
                <div class="col-sm-6">
                    <asp:DropDownList ID="ddlArea" class="form-control" runat="server"></asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-12">
                <div class="col-sm-2">
                    City
                </div>
                <div class="col-sm-6">
                    <asp:DropDownList ID="ddlCity" class="form-control" runat="server"></asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-12">
                <div class="col-sm-2">
                    Prefer Time
                </div>
                <div class="col-sm-3">
                    <asp:TextBox runat="server" ID="txtFromTime" ClientIDMode="Static" class="form-control timepicker"/>
                </div>
                  <div class="col-sm-3">
                    <asp:TextBox runat="server" ID="txtToTime" ClientIDMode="Static" class="form-control timepicker"/>
                </div>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-12">
                <div class="col-sm-2">
                    Final
                </div>
                <div class="col-sm-6">
                    <asp:DropDownList ID="ddlFinal" class="form-control" runat="server">
                        <asp:ListItem Text="Select" Value="false" />
                        <asp:ListItem Text="Yes" Value="true" />
                        <asp:ListItem Text="No" Value="false"/>
                    </asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-12">
                <div class="col-sm-2">
                    Notes.
                </div>
                <div class="col-sm-6">
                    <textarea id="txtNotes" class="form-control" runat="server"></textarea>
                </div>
            </div>
        </div>
        <div class="box-footer">
            <div class="col-sm-12">
                <div class="col-sm-4">
                </div>
                <div class="col-sm-4">
                    <asp:Button ID="btnsave" CssClass="btn  btn-primary" runat="server" class="btn btn-primary" Text="Save" OnClick="btnsave_Click" />
                    <asp:Button ID="btncancle" runat="server" class="btn btn-default" Text="Cance" OnClick="btncancle_Click" />
                </div>
                <div class="col-sm-4">
                </div>
            </div>
        </div>
         
    </div>
      <script type="text/javascript">
        $(document).ready(function () {
            $('#txtFromTime').timepicker();
            $('#txtToTime').timepicker();
            $('input.timepicker').timepicker({});
            $('[id*=ddlCourse]').multiselect({
                includeSelectAllOption: true,
                buttonWidth: '100%',
                numberDisplayed:5

            });

        });

    </script>
</asp:Content>

<%@ Page Title="Course" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="CourseAddEdit.aspx.cs" Inherits="apcc.admin.CourseAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" class="container">
    <div class="box box-info" style="min-height: 755px;">
        <div class="row">
            <div class="box-header with-border">
                <h3 runat="server" id="lblHead" class="box-title">Course Add</h3>
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
                    <div class="col-sm-2">
                        Course Name 
                    </div>
                    <div class="col-sm-6">
                        <asp:TextBox ID="txtCourseName" class="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator CssClass="reqValidate" ErrorMessage="Required" ControlToValidate="txtCourseName" runat="server" />
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        Course Fee 
                    </div>
                    <div class="col-sm-6">
                        <asp:TextBox ID="txtCourserFee" class="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator CssClass="reqValidate" ErrorMessage="Required" ControlToValidate="txtCourserFee" runat="server" />
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        Course Duaration 
                    </div>
                    <div class="col-sm-6">
                        <asp:TextBox ID="txtCourseDuaration" class="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator CssClass="reqValidate" ErrorMessage="Required" ControlToValidate="txtCourseDuaration" runat="server" />
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        Active
                    </div>
                    <div class="col-sm-6">
                        <asp:CheckBox ID="ChkActive" class="form-check-input" runat="server"></asp:CheckBox>
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
    </div>
</asp:Content>

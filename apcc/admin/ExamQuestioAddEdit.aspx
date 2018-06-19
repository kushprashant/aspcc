<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ExamQuestioAddEdit.aspx.cs" Inherits="apcc.admin.ExamQuestioAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box box-info">
        <div class="row">
            <div class="box-header with-border">
                <h3 runat="server" id="lblHead" class="box-title margingleft10">
                    
                </h3>
            </div>
        </div>
        <div class="box-body">
            <div class="form-group row" runat="server" id="DivSuccess" visible="false">
                <div class="col-sm-12">
                    <div class="alert alert-success alert-s">
                        <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
                        <h4><i class="icon fa fa-check"></i>Success!</h4>
                        <asp:Label Text="Question Add Sccussesfully." ID="lblSuccess" runat="server" />
                    </div>
                </div>
            </div>
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
                        <label for="usr">Question Name:</label>
                    </div>
                    <div class="col-sm-6">
                        <textarea  runat="server" id="txtExamName" ClientIDMode="Static" class="form-control" />
                    </div>
                </div>
            </div>
             <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Option 1</label>
                    </div>
                    <div class="col-sm-6">
                        <asp:TextBox runat="server" ID="txtOption1" ClientIDMode="Static"  class="form-control" />
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Option 2</label>
                    </div>
                    <div class="col-sm-6">
                        <asp:TextBox runat="server" ID="txtOption2" ClientIDMode="Static"  class="form-control" />
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Option 3</label>
                    </div>
                    <div class="col-sm-6">
                        <asp:TextBox runat="server" ID="txtOption3" ClientIDMode="Static"  class="form-control" />
                    </div>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Option 4</label>
                    </div>
                    <div class="col-sm-6">
                        <asp:TextBox runat="server" ID="txtOption4" ClientIDMode="Static" class="form-control" />
                    </div>
                </div>
            </div>
             <div class="form-group row">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label for="usr">Correct Option</label>
                    </div>
                    <div class="col-sm-6">
                        <asp:TextBox runat="server" ID="txtCorrectAnswer" ClientIDMode="Static"  class="form-control" />
                    </div>
                </div>
            </div>
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
    </div>
</asp:Content>

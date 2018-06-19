<%@ Page Title="" Language="C#" MasterPageFile="~/Students/StudentMaster.Master" AutoEventWireup="true" CodeBehind="StudentExam.aspx.cs" Inherits="apcc.Students.StudentExam" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        input[type="radio"] {
            margin-right: 10px;
        }
    </style>
    <div class="box box-info">
        <div class="row">
            <div class="box-header with-border">
                <div class="col-lg-12">
                    <div class="col-lg-6">
                        <h2 class="box-title">
                            <asp:Label Text="Exam Name" ID="lblExamName" runat="server" />
                        </h2>
                    </div>
                    <div class="col-lg-6">
                        <h2 class="box-title">
                            <asp:Label Text="1" ID="noofQuestin" runat="server" />
                        </h2>
                    </div>
                </div>
            </div>
        </div>
        <div>
            <div class="box-body">
                <hr />
                <div class="col-lg-12">
                     <h3 class="box-title">
                    <asp:Label Text="text" ID="ltrQuestin" runat="server" /></h3>
                </div>
                <hr />
                <div class="col-lg-12">
                    <div class="col-lg-6">

                        <asp:RadioButton ID="rbOption1" CssClass="marginright10" value="1" runat="server" GroupName="OptionGrp" Text="Option 1" />
                    </div>
                    <div class="col-lg-6">
                        <asp:RadioButton ID="rbOption2" CssClass="marginright10" value="2" runat="server" GroupName="OptionGrp" Text="Option 2" />
                    </div>
                </div>
                <div class="col-lg-12">
                    <div class="col-lg-6">
                        <asp:RadioButton ID="rbOption3" CssClass="marginright10" value="3" runat="server" GroupName="OptionGrp" Text="Option 3" />
                    </div>
                    <div class="col-lg-6">
                        <asp:RadioButton ID="rbOption4" CssClass="marginright10" value="4" runat="server" GroupName="OptionGrp" Text="Option 4" />
                    </div>
                </div>
                <hr />
                <hr />

            </div>
            <hr />
            <div class="row">
                <div class="col-lg-12">
                    <div class="col-lg-3">
                        <asp:Button ID="btnPrevious" Visible="false" runat="server" Text="Previous" class="btn btn-lg btn-primary" OnClick="btnPrevious_Click" />
                    </div>
                    <div class="col-lg-4">
                    </div>
                    <div class="col-lg-3">
                        <asp:Button ID="btnNext" runat="server" Text="Next" class="btn btn-lg btn-primary" OnClick="btnNext_Click" />
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12">
                    <div class="col-lg-3">
                    </div>
                     <div class="col-lg-3">
                         <asp:Button ID="btnFinish"  Visible="false" runat="server" Text="Finish" class="btn btn-lg btn-danger" OnClick="btnFinish_Click" />
                    </div>
                     <div class="col-lg-3">
                    </div>
                </div>
            </div>
            <hr />
        </div>
    </div>
    <asp:HiddenField ID="hdnStdexamid" Value="0" runat="server" />
    <asp:HiddenField ID="hdnTotalQuestion" Value="0" runat="server" />
    <asp:HiddenField ID="hdnPrevious" Value="0" runat="server" />
    <asp:HiddenField ID="hdnNext" Value="0" runat="server" />
</asp:Content>

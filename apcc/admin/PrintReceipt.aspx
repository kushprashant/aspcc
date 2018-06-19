<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="PrintReceipt.aspx.cs" Inherits="apcc.admin.PrintReceipt" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="box box-info">
        <div class="row">
            <div class="box-header with-border">
                <div class="col-lg-12">
                    <div class="col-lg-6">
                        <h3 class="box-title" id="h3StudentName" runat="server">Student Name</h3>
                    </div>
                    <div class="col-lg-3">
                    </div>
                    <div class="col-lg-3 ">
                        <asp:Button Text="Print" CssClass="btn btn-primary right" ID="btnprintq" OnClick="btnprintq_Click" runat="server" />
                    </div>
                </div>
            </div>

        </div>
        <div class="row">
            <div class="box-body">
                <div class="table-responsive">
                    <asp:HiddenField ID="hdnAdmissionid" runat="server" />
                    <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
                    <rsweb:ReportViewer ID="rptReciptPrint" runat="server" BorderColor="Black" BorderWidth="1px" Width="56%" ShowPrintButton="true">
                    </rsweb:ReportViewer>
                </div>
            </div>
            <iframe id="frmPrint" name="IframeName" width="500"
                height="200" runat="server"
                style="display: none" runat="server"></iframe>
        </div>
    </div>
</asp:Content>

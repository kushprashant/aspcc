<%@ Page Title="AdmissionForm" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="AdmissionFormPrint.aspx.cs" Inherits="apcc.admin.AdmissionFormPrint" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <%--  <rsweb:ReportViewer ID="rptAdmissionForm" runat="server" BorderColor="Black" 
            BorderWidth="2pt"></rsweb:ReportViewer>--%>
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
                    <rsweb:ReportViewer ID="ReportViewer1" runat="server" BorderColor="Black" BorderWidth="1px" Width="56%" ShowPrintButton="true">
                    </rsweb:ReportViewer>
                </div>
            </div>
              <iframe id="frmPrint" name="IframeName" width="500"
                height="200" runat="server"
                style="display: none" runat="server"></iframe>
        </div>
    </div>

    <asp:HiddenField  id="hdnAdmissionid" runat="server" />

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="QuestionPrint.aspx.cs" Inherits="apcc.admin.QuestionPrint" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
      
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box box-info" hidden>
        <div class="row">
            <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
            <rsweb:ReportViewer ID="rptQuestion" runat="server" BorderColor="Black" BorderWidth="1px" Width="56%" ShowPrintButton="true">
            </rsweb:ReportViewer>
        </div>
        <div class="row">
            <div class="box-header with-border">
                <div class="col-lg-12">
                    <div class="col-lg-6">
                        <asp:Button Text="Print" ID="btnPrint" OnClick="btnPrint_Click" runat="server" />
                    </div>
                </div>
            </div>
            <iframe id="frmPrint" name="IframeName" width="500"
                height="200" runat="server"
                style="display: none" runat="server"></iframe>
        </div>
    </div>
    <div class="box box-info">
        <div class="row">
             <div class="box-header with-border">
                <div class="col-lg-12">
                    <div class="col-lg-6">
                        <h3 class="box-title" id="h3Exmaname" runat="server">Exam Name</h3>
                    </div>
                    <div class="col-lg-3">
                    </div>
                    <div class="col-lg-3 ">
                         <asp:Button Text="Print"  CssClass="btn btn-primary right"  ID="btnprintq" OnClick="btnprint_Click1" runat="server" />
                    </div>
                </div>
            </div>
           
        </div>
        
    </div>
    <div class="box box-info" id="divquestion" runat="server">
    </div>


    <script type="text/javascript">
        $(document).ready(function () {
            $("#grvQuestion").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable({
                "columnDefs": [
            { "width": "10%", "targets": 0 },
                { "width": "20%", "targets": 2 }
                ]
            });
        });
    </script>
</asp:Content>

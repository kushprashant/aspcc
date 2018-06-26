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
                        <asp:Button Text="Print" ID="btnPrint" OnClientClick="print()" runat="server" />
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
                        <%-- <asp:Button Text="Print"   CssClass="btn btn-primary right"  ID="btnprintq" OnClick="btnprint_Click1" runat="server" />--%>
                         <asp:Button Text="Print" ID="Button1" CssClass="btn btn-primary right" OnClientClick="print()" runat="server" />
                    </div>
                </div>
            </div>
           
        </div>
        
    </div>
    <div id="divHead" style="display:none">
        <div style="text-align:center">
            <label style=font-family:ravel;font-size:large;>APURVA STAR PLUSE COMPUTER CLASSES</label>
             <br>
            <span> FF - 6, Vishwash City-1,Shayonacity,Chanakyapuri, Ghatlodia, Ahmedabad, Gujarat 380061 </span>
            <br>
            <span>Email: apurvastarpulse @yahoo.com Mobile : 9978532833 </span>
            <br>
            <h3 class="box-title" id="printhdHead" runat="server">Exam Name</h3>
        </div>
    </div>
    <div class="box box-info" id="divquestion" runat="server" ClientIDMode="Static">
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

        function print() {
            var divHead = document.getElementById('divHead');
            var divToPrint = document.getElementById('divquestion');

            var newWin = window.open('', 'Print-Window');

            newWin.document.open();

            newWin.document.write('<html><body onload="window.print()">' + divHead.innerHTML + divToPrint.innerHTML + '</body></html>');

            newWin.document.close();

            setTimeout(function () { newWin.close(); }, 10);
        }
    </script>
</asp:Content>

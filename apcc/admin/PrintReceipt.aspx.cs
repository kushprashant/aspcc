using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bal;
using dal;
using dal.edmx;
using System.Globalization;
using System.Data;
using Microsoft.Reporting.WebForms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace apcc.admin
{
    public partial class PrintReceipt : System.Web.UI.Page
    {
        public bal.courseopration courseOp = new bal.courseopration();
        public bal.balComman com = new balComman();
        public bal.BalAdmissionOpration objAdmOp = new bal.BalAdmissionOpration();
        public int? Admissionid = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                bindReciptDetails();
            }
        }

        public void bindReciptDetails() {
            try
            {
                if (Request.QueryString["id"] != null && Request.QueryString["InstallmentNo"] != null)
                {
                    Admissionid = Convert.ToInt32(Request.QueryString["id"].ToString());
                    hdnAdmissionid.Value = Convert.ToString(Admissionid);
                    int InstallmentNo = Convert.ToInt32(Request.QueryString["InstallmentNo"].ToString());
                    getAdmissionById_Result objadm = new getAdmissionById_Result();
                    List<getAdmissionById_Result> ListAdmistion = new List<getAdmissionById_Result>();
                    objadm = objAdmOp.GetAdminssionById(Admissionid);
                    h3StudentName.InnerText = objadm.fname.ToUpper() + " " + objadm.Lname.ToUpper();
                    ListAdmistion.Add(objadm);
                    DataTable DT = Comman.CommanUtils.ToDataTable(ListAdmistion.ToList());
                    DataTable dt = DT;

                    string ReceiptNo = "1";
                    string InstallmentDate = string.Empty;
                    string InstallmentRsWord = string.Empty;
                    string InstallmentRs = string.Empty;
                    if (InstallmentNo == 1)
                    {
                        InstallmentDate = objadm.Installment1Date_S;
                        InstallmentRsWord = objadm.Installment1RsInWord;
                        InstallmentRs = Convert.ToString(objadm.Installment1Rs);
                    }
                    else if (InstallmentNo == 2) {
                        InstallmentDate = objadm.Installment2Date_S;
                        InstallmentRsWord = objadm.Installment2RsInWord;
                        InstallmentRs = Convert.ToString(objadm.Installment2Rs);
                    }
                    else if (InstallmentNo == 3)
                    {
                        InstallmentDate = objadm.Installment3Date_S;
                        InstallmentRsWord = objadm.Installment3RsInWord;
                        InstallmentRs = Convert.ToString(objadm.Installment3Rs);

                    }
                    else if (InstallmentNo == 4)
                    {
                        InstallmentDate = objadm.Installment4Date_S;
                        InstallmentRsWord = objadm.Installmen4RsInWord;
                        InstallmentRs = Convert.ToString(objadm.Installment4Rs);
                    }
                    else if (InstallmentNo == 5)
                    {
                        InstallmentDate = objadm.Installment5Date_S;
                        InstallmentRsWord = objadm.Installment5RsInWord;
                        InstallmentRs = Convert.ToString(objadm.Installment5Rs);
                    }
                    else if (InstallmentNo == 6)
                    {
                        InstallmentDate = objadm.Installment6Date_S;
                        InstallmentRsWord = objadm.Installment6RsInWord;
                        InstallmentRs = Convert.ToString(objadm.Installment6Rs);
                    }
                    else if (InstallmentNo == 7)
                    {
                        InstallmentDate = objadm.Installment7Date_S;
                        InstallmentRsWord = objadm.Installment7RsInWord;
                        InstallmentRs = Convert.ToString(objadm.Installment7Rs);
                    }
                    else if (InstallmentNo == 8)
                    {
                        InstallmentDate = objadm.Installment7Date_S;
                        InstallmentRsWord = objadm.Installment7RsInWord;
                        InstallmentRs = Convert.ToString(objadm.Installment7Rs);
                    }
                    else if (InstallmentNo == 9)
                    {
                        InstallmentDate = objadm.Installment8Date_S;
                        InstallmentRsWord = objadm.Installment8RsInWord;
                        InstallmentRs = Convert.ToString(objadm.Installment8Rs);
                    }
                    else if (InstallmentNo == 10)
                    {
                        InstallmentDate = objadm.Installment10Date_S;
                        InstallmentRsWord = objadm.Installment10RsInWord;
                        InstallmentRs = Convert.ToString(objadm.Installment10Rs);

                    }

                    ReportParameter rp1 = new ReportParameter("ReceiptNo", ReceiptNo.ToString());
                    ReportParameter rp2 = new ReportParameter("InstallmentDate", InstallmentDate.ToString());
                    ReportParameter rp3 = new ReportParameter("InstallmentRsWord", InstallmentRsWord.ToString());
                    ReportParameter rp4 = new ReportParameter("InstallmentRs", InstallmentRs.ToString());

                    rptReciptPrint.SizeToReportContent = true;
                    rptReciptPrint.ShowPrintButton = true;
                    rptReciptPrint.LocalReport.ReportPath = Server.MapPath("~/admin/Reports/rdlc/RecepitPrint.rdlc");
                    rptReciptPrint.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3, rp4 });
                    rptReciptPrint.LocalReport.DataSources.Clear();

                    ReportDataSource _rsource = new ReportDataSource("Receipt", dt);
                    rptReciptPrint.LocalReport.DataSources.Add(_rsource);
                    rptReciptPrint.LocalReport.Refresh();
                }
            }
            catch (Exception ex) 
            {

                throw;
            }
            
        }

        protected void btnprintq_Click(object sender, EventArgs e)
        {
           


            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;

            byte[] bytes = rptReciptPrint.LocalReport.Render("PDF", null, out mimeType,
                           out encoding, out extension, out streamids, out warnings);

            FileStream fs = new FileStream(HttpContext.Current.Server.MapPath("output.pdf"), FileMode.Create);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();

            //Open exsisting pdf
            Document document = new Document(PageSize.LETTER);
            PdfReader reader = new PdfReader(HttpContext.Current.Server.MapPath("output.pdf"));
            //Getting a instance of new pdf wrtiter
            
            string uploadPath = Server.MapPath("~/StudentRecipts");
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }
            string stdpath = Server.MapPath("~/StudentRecipts/" + hdnAdmissionid.Value);
            if (!Directory.Exists(stdpath))
            {
                Directory.CreateDirectory(stdpath);
            }
            string intallno = Request.QueryString["InstallmentNo"].ToString();
            string filename = hdnAdmissionid.Value + "_" + h3StudentName.InnerText+"_"+ intallno + ".pdf";
            string path = Path.Combine(stdpath, filename);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
            document.Open();
            PdfContentByte cb = writer.DirectContent;

            int i = 0;
            int p = 0;
            int n = reader.NumberOfPages;
            Rectangle psize = reader.GetPageSize(1);

            float width = psize.Width;
            float height = psize.Height;

            //Add Page to new document
            while (i < n)
            {
                document.NewPage();
                p++;
                i++;

                PdfImportedPage page1 = writer.GetImportedPage(reader, i);
                cb.AddTemplate(page1, 0, 0);
            }

            //Attach javascript to the document
            PdfAction jAction = PdfAction.JavaScript("this.print(true);\r", writer);
            writer.AddJavaScript(jAction);
            document.Close();

            //Attach pdf to the iframe
            frmPrint.Attributes["src"] = "~/StudentRecipts/" + hdnAdmissionid.Value+"/" + filename;
        }
    }
}
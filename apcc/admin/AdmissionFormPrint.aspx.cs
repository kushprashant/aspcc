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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace apcc.admin
{
    public partial class AdmissionFormPrint : System.Web.UI.Page
    {
        

        public bal.BalAdmissionOpration objAdmOp = new bal.BalAdmissionOpration();
        public int? Admissionid = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                if (Request.QueryString["id"] != null)
                {
                    Admissionid = Convert.ToInt32(Request.QueryString["id"].ToString());
                    hdnAdmissionid.Value = Convert.ToString(Admissionid);
                    bindRdlc(Admissionid);
                }
            }
           
        }

        public void bindRdlc(int? Admissionid)
        {
            try
            {
                getAdmissionById_Result objadm = new getAdmissionById_Result();
                List<getAdmissionById_Result> ListAdmistion = new List<getAdmissionById_Result>();
                objadm = objAdmOp.GetAdminssionById(Admissionid);
                h3StudentName.InnerText = objadm.fname.ToUpper() +" "+ objadm.Lname.ToUpper();
                ListAdmistion.Add(objadm);
                DataTable DT = Comman.CommanUtils.ToDataTable(ListAdmistion.ToList());
                //rptAdmissionForm.SizeToReportContent = true;
                //rptAdmissionForm.LocalReport.ReportPath = Server.MapPath("~/admin/Reports/rdlc/AdmissioForm.rdlc");
                //rptAdmissionForm.LocalReport.DataSources.Clear();
                //ReportDataSource _rsource = new ReportDataSource("AdmissionFormData", DT);
                //rptAdmissionForm.LocalReport.DataSources.Add(_rsource);
                //rptAdmissionForm.LocalReport.Refresh();

                DataTable dt = DT;
                ReportViewer1.SizeToReportContent = true;
                ReportViewer1.ShowPrintButton = true;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/admin/Reports/rdlc/AdmissionForm.rdlc");
                ReportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource _rsource = new ReportDataSource("DataSet1", dt);
                ReportViewer1.LocalReport.DataSources.Add(_rsource);
                ReportViewer1.LocalReport.Refresh();


            }
            catch (Exception ex)
            {
              
            }
        }

        private DataTable Getdata()
        {
            DataTable _dt = new DataTable();
            _dt.Columns.Add("id");
            _dt.Columns.Add("Name");
            _dt.Columns.Add("Age");
            _dt.Columns.Add("Salary");
            _dt.Rows.Add("1", "Priti", "22", "544566");
            _dt.Rows.Add("2", "anu", "21", "7475");
            _dt.Rows.Add("3", "neha", "24", "4364");
            _dt.Rows.Add("4", "aman", "21", "4353453");
            _dt.Rows.Add("5", "rakhi", "34", "34544");
            _dt.Rows.Add("6", "priyanka", "24", "435435");
            return _dt;
        }

        protected void btnprintq_Click(object sender, EventArgs e)
        {
            string filename = hdnAdmissionid.Value+"_"+ h3StudentName.InnerText+".pdf";


            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;

            byte[] bytes = ReportViewer1.LocalReport.Render("PDF", null, out mimeType,
                           out encoding, out extension, out streamids, out warnings);

            FileStream fs = new FileStream(HttpContext.Current.Server.MapPath("output.pdf"), FileMode.Create);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();

            //Open exsisting pdf
            Document document = new Document(PageSize.LETTER);
            PdfReader reader = new PdfReader(HttpContext.Current.Server.MapPath("output.pdf"));
            //Getting a instance of new pdf wrtiter

            string uploadPath = Server.MapPath("~/StudentForm");
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }
            string path = Path.Combine(uploadPath, filename);


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
            frmPrint.Attributes["src"] = "~/StudentForm/"+filename;
        }

}
}
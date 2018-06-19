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
using IronPdf;
using System.Text;
using iTextSharp.tool.xml;

namespace apcc.admin
{
    public partial class QuestionPrint : System.Web.UI.Page
    {
        public int Examid = 0;
        public int Questionid = 0;
        public bal.balComman com = new balComman();
        public bal.BalExamopration objBalExam = new BalExamopration();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    Examid = Convert.ToInt32(Request.QueryString["id"].ToString());
                    bindExamDetails(Examid);
                }
            }
        }
        public void bindExamDetails(int id)
        {
            try
            {
                ExamQuestionListByExamId(id);
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bindExamDetails", ex.StackTrace, ex.Message);

            }
        }
        public void ExamQuestionListByExamId(int examId)
        {
            try
            {
                getexamById_Result objExam = new getexamById_Result();
                objExam = objBalExam.GetexamById(Examid);
                h3Exmaname.InnerText = objExam.Name;
                List<getExamQuestionListByExamId_Result> ExamQuestionist = new List<getExamQuestionListByExamId_Result>();
                ExamQuestionist = objBalExam.getExamQuestionListByExamId(examId);

                string html = " <table>  ";
                string style = "text- lign:justify; padding: 0px 10px 5px 10px; margin - left: 50px; ";
                //string borderTopBotstyle = "'border-bottom:1px solid;border-top:1px solid;'";
                //string borderBotstyle = "'border-bottom:1px solid;'";
                string borderTopBotstyle = string.Empty;
                string borderBotstyle = string.Empty;

                foreach (var que in ExamQuestionist)
                {
                    html += "<tr style="+ borderTopBotstyle + " class='trTopBorder'><td colspan='4'><b><label>" + "(  "+que.RowID + " )"+ " " + que.Question + " </label></b></td></tr>";
                    html += "<tr><td width = '500px' >";
                    html += "<label style="+ style + ">"+"1  " + que.Option1 + "</label></td>";
                    html += "<td width = '500px' >";
                    html += "<label style=" + style + ">" + "2  " + que.Option2 + "</label></td></tr>";
                    html += "<tr><td width = '500px' >";
                    html += "<label style=" + style + ">" + "3  " + que.Option3 + "</label></td>";
                    html += "<td width = '500px' >";
                    html += "<label style=" + style + ">" + "4  " + que.Option4 + "</label></td></tr>";
                    html += "<tr style=" + borderBotstyle + "><td colspan='4' >";
                    html += "<label style='text - align: justify;'>" + "Correct Ans. " + que.CorrectAns + "</label></td></tr>";
                }
                html += "</table>";

                divquestion.InnerHtml = html;
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "ExamQuestionListByExamId", ex.StackTrace, ex.Message);
            }
        }


        //public void ExamQuestionListByExamId(int examId, string exmaName)
        //{
        //    try
        //    {
        //        List<getExamQuestionListByExamId_Result> ExamQuestionist = new List<getExamQuestionListByExamId_Result>();
        //        ExamQuestionist = objBalExam.getExamQuestionListByExamId(examId);
        //        DataTable DT = Comman.CommanUtils.ToDataTable(ExamQuestionist.ToList());
        //        DataTable dt = DT;
        //        ReportParameter rp1 = new ReportParameter("exmaName", exmaName);
        //        rptQuestion.SizeToReportContent = true;
        //        rptQuestion.ShowPrintButton = true;
        //        rptQuestion.LocalReport.ReportPath = Server.MapPath("~/admin/Reports/rdlc/QuestionListPrint.rdlc");
        //        rptQuestion.LocalReport.SetParameters(new ReportParameter[] { rp1 });
        //        rptQuestion.LocalReport.DataSources.Clear();

        //        ReportDataSource _rsource = new ReportDataSource("QuestioList", dt);
        //        rptQuestion.LocalReport.DataSources.Add(_rsource);
        //        rptQuestion.LocalReport.Refresh();

        //    }
        //    catch (Exception ex)
        //    {
        //        com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "ExamQuestionListByExamId", ex.StackTrace, ex.Message);
        //    }
        //}



        protected void btnPrint_Click(object sender, EventArgs e)
        {
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;

            byte[] bytes = rptQuestion.LocalReport.Render("PDF", null, out mimeType,
                           out encoding, out extension, out streamids, out warnings);

            FileStream fs = new FileStream(HttpContext.Current.Server.MapPath("output.pdf"), FileMode.Create);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();

            //Open exsisting pdf
            Document document = new Document(PageSize.LETTER);
            PdfReader reader = new PdfReader(HttpContext.Current.Server.MapPath("output.pdf"));
            //Getting a instance of new pdf wrtiter
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(
               HttpContext.Current.Server.MapPath("Print.pdf"), FileMode.Create));
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
            frmPrint.Attributes["src"] = "Print.pdf";
        }

        protected void btnprint_Click1(object sender, EventArgs e)
        {
            try
            {
                
              
                string filname = h3Exmaname.InnerText.Replace(" ","").Trim() + ".pdf";

                PdfPrintOptions printopt = new PdfPrintOptions();
                printopt.CssMediaType = PdfPrintOptions.PdfCssMediaType.Screen;
                string csspath = Server.MapPath("~/admin/css/AdminStyle.css");
                var uri = new System.Uri(csspath);
                var converted = uri.AbsoluteUri;
                printopt.CustomCssUrl = uri;
                HtmlToPdf Renderer = new IronPdf.HtmlToPdf(printopt);
                string html = divquestion.InnerHtml;
                Renderer.PrintOptions.CssMediaType = PdfPrintOptions.PdfCssMediaType.Screen;

                var PDF = Renderer.RenderHtmlAsPdf(html, uri);
                
                string watermarktext = "<label style=font-family:ravel;>APURVA STAR PLUSE COMPUTER CLASSES</label> <br> FF - 6, Vishwash City-1,Shayonacity,Chanakyapuri, Ghatlodia, Ahmedabad, Gujarat 380061 <br>Email: apurvastarpulse @yahoo.com <br>Mobile : 9978532833 ";
                PDF.WatermarkAllPages("<h2 style='color:blue'>" + watermarktext + "</h2>", IronPdf.PdfDocument.WaterMarkLocation.MiddleCenter, 50, -45);

                #region header
                SimpleHeaderFooter head = new SimpleHeaderFooter();
                head.CenterText = h3Exmaname.InnerText;
                head.FontFamily = "Ravel";
                head.DrawDividerLine = true;
                head.FontSize = 14;
                #endregion
                PDF.AddHeaders(head, false);

                SimpleHeaderFooter Footer = new SimpleHeaderFooter()
                {
                    LeftText = "{date} {time}",
                    RightText = "Page {page} of {total-pages}",
                    DrawDividerLine = true,
                    FontSize = 8
                };
                PDF.AddFooters(Footer, false);
                //Renderer.PrintOptions.CssMediaType = PdfPrintOptions.PdfCssMediaType.Print;
                //or



                string uploadPath = Server.MapPath("~/QuestionPdf");
                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }
                PDF.SaveAs(Path.Combine(uploadPath, filname));

                Response.ContentType = "application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename="+ filname);
                Response.TransmitFile(Path.Combine(uploadPath, filname.Trim()));
                Response.End();

            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "btnprint_Click1", ex.StackTrace, ex.Message);
            }
            
        }

        public void pdfGenrate(string html) {
            StringReader sr = new StringReader(html);
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
            pdfDoc.Close();
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=HTML.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Write(pdfDoc);
            Response.End();
        }
    }
}
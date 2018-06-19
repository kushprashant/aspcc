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

namespace apcc.admin
{
    public partial class AdmissionAddEdit : System.Web.UI.Page
    {

        public bal.courseopration courseOp = new bal.courseopration();
        public bal.balComman com = new balComman();
        public bal.BalAdmissionOpration objAdmOp = new bal.BalAdmissionOpration();
        public int? Admissionid = null;
        protected void Page_PreInit(object sender, EventArgs e)
        {

            List<string> keys = Request.Form.AllKeys.Where(key => key.Contains("txtrdInstallment")).ToList();
            //if(keys.Count==0)
            this.txtNoofInstallment_TextChanged(keys.Count);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bindCourseDropDown();
                bindAreaDropDown();
                if (Request.QueryString["id"] != null)
                {
                    Admissionid = Convert.ToInt32(Request.QueryString["id"].ToString());
                    lblHead.InnerText = "Admission Update";
                    btnsave.Text = "Update";
                    bindAdmissionDetails(Admissionid);
                }
            }
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    clsAdmission objadm = new clsAdmission();
                    if (Request.QueryString["id"] != null)
                    {
                        Admissionid = Convert.ToInt32(Request.QueryString["id"].ToString());
                        objadm.Id = Admissionid;
                    }
                    objadm.AdmissionNo = txtAdmissionNo.Text.Trim();
                    objadm.RegNo = txtRegNo.Text.Trim();
                    objadm.AdmissionDate = Comman.CommanUtils.convertDDMMYYYY(txtAdmissionDate.Text.Trim());
                    objadm.fname = txtFirstName.Text.Trim();
                    objadm.Mname = txtMiddelName.Text.Trim();
                    objadm.Lname = txtLastName.Text.Trim();
                    objadm.Address = txtAdress.InnerText.Trim();
                    objadm.MobileF = txtMobileF.Text.Trim();
                    objadm.MobileH = txtMobileH.Text.Trim();
                    objadm.MobileP = txtMobileP.Text.Trim();
                    objadm.Email = txtEmail.Text.Trim();
                    objadm.AreId = Convert.ToInt32(ddlArea.SelectedValue);
                    objadm.QualificationId = txtQualification.Text.Trim();
                    objadm.StreamId = Convert.ToInt32(ddlStream.SelectedValue);
                    objadm.OccupationId = Convert.ToInt32(ddloccupation.SelectedValue);
                    string courseId = string.Empty;
                    foreach (ListItem item in ddlCourse.Items)
                    {
                        if (item.Selected)
                        {
                            courseId += item.Value + ",";
                        }
                    }
                    objadm.CourseId = courseId;
                    objadm.SchoolName = txtSchoolName.Text.Trim();
                    objadm.BirthDate = Comman.CommanUtils.convertDDMMYYYY(txtBirthDate.Text.Trim());
                    objadm.PreferTimeFrom = txtFromTime.Text.Trim();
                    objadm.PreferTimeTO = txtToTime.Text.Trim();
                    objadm.Remark = txtRemark.InnerText.Trim();
                    objadm.TotalFees = Convert.ToDecimal(txtTotalFees.Text.Trim());
                    objadm.DisCount = Convert.ToInt32(txtDisCount.Text.Trim());
                    objadm.NoOfInstallment = Convert.ToInt32(txtNoofInstallment.Text.Trim());
                    objadm.NetFees = Convert.ToDecimal(txtNetFees.Text.Trim());
                    foreach (TextBox textBox in pnlInstallmentBoxes.Controls.OfType<TextBox>())
                    {
                        if (textBox.ID == "txtdateInstallment1")
                        {
                            objadm.Installment1Date = Comman.CommanUtils.convertDDMMYYYY(textBox.Text);
                        }
                        if (textBox.ID == "txtrdInstallment1")
                        {

                            objadm.Installment1Rs = Convert.ToDecimal(string.IsNullOrEmpty(textBox.Text) ? "0" : textBox.Text);
                        }
                        if (textBox.ID == "txtdateInstallment2")
                        {
                            objadm.Installment2Date = Comman.CommanUtils.convertDDMMYYYY(textBox.Text);
                        }
                        if (textBox.ID == "txtrdInstallment2")
                        {
                            objadm.Installment2Rs = Convert.ToDecimal(string.IsNullOrEmpty(textBox.Text) ? "0" : textBox.Text);
                        }
                        if (textBox.ID == "txtdateInstallment3")
                        {
                            objadm.Installment3Date = Comman.CommanUtils.convertDDMMYYYY(textBox.Text);
                        }
                        if (textBox.ID == "txtrdInstallment3")
                        {
                            objadm.Installment3Rs = Convert.ToDecimal(string.IsNullOrEmpty(textBox.Text) ? "0" : textBox.Text);
                        }
                        if (textBox.ID == "txtdateInstallment4")
                        {
                            objadm.Installment4Date = Comman.CommanUtils.convertDDMMYYYY(textBox.Text);
                        }
                        if (textBox.ID == "txtrdInstallment4")
                        {
                            objadm.Installment4Rs = Convert.ToDecimal(string.IsNullOrEmpty(textBox.Text) ? "0" : textBox.Text);
                        }
                        if (textBox.ID == "txtdateInstallment5")
                        {
                            objadm.Installment5Date = Comman.CommanUtils.convertDDMMYYYY(textBox.Text);
                        }
                        if (textBox.ID == "txtrdInstallment5")
                        {
                            objadm.Installment5Rs = Convert.ToDecimal(string.IsNullOrEmpty(textBox.Text) ? "0" : textBox.Text);
                        }
                    }

                    int result = objAdmOp.InsertUpdateAdmission(objadm);

                    if (result > 0)
                    {
                        Response.Redirect("AdmissionList.aspx");
                    }
                    else {
                        lblErrorMsg.Text = "Please Try after some Time.";
                    }
                }
                
            }
            catch (Exception ex)
            {

                lblErrorMsg.Text = "Please Try after some Time.";
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "btnsave_Click", ex.StackTrace, ex.Message);
            }
        }

        protected void btncancle_Click(object sender, EventArgs e)
        {

        }
        public void bindCourseDropDown()
        {
            List<getCourseList_Result> courselist = new List<getCourseList_Result>();
            bal.courseopration course = new bal.courseopration();
            courselist = courseOp.GetCourseList();
            //getCourseList_Result tmp = new getCourseList_Result();
            //tmp.CourseName = "Select Course";
            //tmp.Id =0;
            //tmp.Fee = 0;
            //courselist.Add(tmp);
            ddlCourse.DataSource = courselist;
            ddlCourse.DataTextField = "CourseName";
            ddlCourse.DataValueField = "Id";
            ddlCourse.DataBind();
            ddlCourse.SelectedValue = "0";
        }
        public void bindAreaDropDown()
        {
            using (aspccEntities db = new aspccEntities())
            {
                var Arealist = db.Areas.ToList();
                ddlArea.DataSource = Arealist;
                ddlArea.DataTextField = "AreaName";
                ddlArea.DataValueField = "Id";
                ddlArea.DataBind();
            }

        }
        protected void txtNoofInstallment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int noofint = Convert.ToInt32(txtNoofInstallment.Text);
                this.txtNoofInstallment_TextChanged(noofint);
            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "txtNoofInstallment_TextChanged", ex.StackTrace, ex.Message);

            }
        }
        protected void txtNoofInstallment_TextChanged(int NoofInstallment)
        {
            try
            {
                int noofint = NoofInstallment;


                string divstart = " <div class='form-group row'><div class='col-sm-12'> <div class='col-sm-2'>";
                string divend = " </div> </div>";

                ContentPlaceHolder cph = (ContentPlaceHolder)this.Master.FindControl("ContentPlaceHolder1");
                Panel pnlInstallmentBoxes = (Panel)cph.FindControl("pnlInstallmentBoxes");

                for (int i = 0; i < noofint; i++)
                {
                    Literal lts = new Literal();
                    lts.Text = divstart;
                    pnlInstallmentBoxes.Controls.Add(lts);
                    Label lbl = new Label();
                    lbl.Text = "Installment " + (i + 1);
                    lbl.ID = "lblInstallment" + (i + 1);
                    lbl.CssClass = "spnLabel";
                    pnlInstallmentBoxes.Controls.Add(lbl);

                    Literal ltld = new Literal();
                    ltld.Text = "</div>";
                    pnlInstallmentBoxes.Controls.Add(ltld);

                    Literal ltltIs = new Literal();
                    ltltIs.Text = "<div class='col-sm-3'>";
                    pnlInstallmentBoxes.Controls.Add(ltltIs);
                    TextBox txt = new TextBox();
                    txt.ID = "txtdateInstallment" + (i + 1);
                    txt.CssClass = "form-control clsdatepicker";
                    txt.Attributes.Add("placeholder", "Installment " + (i + 1) + " Date");
                    pnlInstallmentBoxes.Controls.Add(txt);
                    Literal ltltIe = new Literal();
                    ltltIe.Text = "</div>";
                    pnlInstallmentBoxes.Controls.Add(ltltIe);

                    Literal ltltRs = new Literal();
                    ltltRs.Text = "<div class='col-sm-3'>";
                    pnlInstallmentBoxes.Controls.Add(ltltRs);
                    TextBox txt1 = new TextBox();
                    txt1.ID = "txtrdInstallment" + (i + 1);
                    txt1.CssClass = "form-control";
                    txt1.Attributes.Add("placeholder", "Installment " + (i + 1) + " Rs");
                    pnlInstallmentBoxes.Controls.Add(txt1);
                    Literal ltltre = new Literal();
                    ltltre.Text = "</div>";
                    pnlInstallmentBoxes.Controls.Add(ltltre);
                    Literal lte = new Literal();
                    lte.Text = divend;
                    pnlInstallmentBoxes.Controls.Add(lte);
                }

            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "txtNoofInstallment_TextChanged", ex.StackTrace, ex.Message);

            }
        }

        protected void AddNoofInstallment(int id)
        {
            try
            {
                int i = id;
                string divstart = " <div class='form-group row'><div class='col-sm-12'> <div class='col-sm-2'>";
                string divend = " </div> </div>";
                ContentPlaceHolder cph = (ContentPlaceHolder)this.Master.FindControl("ContentPlaceHolder1");
                Panel pnlInstallmentBoxes = (Panel)cph.FindControl("pnlInstallmentBoxes");
                    Literal lts = new Literal();
                    lts.Text = divstart;
                    pnlInstallmentBoxes.Controls.Add(lts);
                    Label lbl = new Label();
                    lbl.Text = "Installment " + (i + 1);
                    lbl.ID = "lblInstallment" + (i + 1);
                    lbl.CssClass = "spnLabel";
                    pnlInstallmentBoxes.Controls.Add(lbl);

                    Literal ltld = new Literal();
                    ltld.Text = "</div>";
                    pnlInstallmentBoxes.Controls.Add(ltld);

                    Literal ltltIs = new Literal();
                    ltltIs.Text = "<div class='col-sm-3'>";
                    pnlInstallmentBoxes.Controls.Add(ltltIs);
                    TextBox txt = new TextBox();
                    txt.ID = "txtdateInstallment" + (i + 1);
                    txt.CssClass = "form-control clsdatepicker";
                    txt.Attributes.Add("placeholder", "Installment " + (i + 1) + " Date");
                    pnlInstallmentBoxes.Controls.Add(txt);
                    Literal ltltIe = new Literal();
                    ltltIe.Text = "</div>";
                    pnlInstallmentBoxes.Controls.Add(ltltIe);

                    Literal ltltRs = new Literal();
                    ltltRs.Text = "<div class='col-sm-3'>";
                    pnlInstallmentBoxes.Controls.Add(ltltRs);
                    TextBox txt1 = new TextBox();
                    txt1.ID = "txtrdInstallment" + (i + 1);
                    txt1.CssClass = "form-control";
                    txt1.Attributes.Add("placeholder", "Installment " + (i + 1) + " Rs");
                    pnlInstallmentBoxes.Controls.Add(txt1);
                    Literal ltltre = new Literal();
                    ltltre.Text = "</div>";
                    pnlInstallmentBoxes.Controls.Add(ltltre);
                    Literal lte = new Literal();
                    lte.Text = divend;
                    pnlInstallmentBoxes.Controls.Add(lte);
                

            }
            catch (Exception ex)
            {

                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "AddNoofInstallment", ex.StackTrace, ex.Message);
            }
        }
        public void bindAdmissionDetails(int? Admissionid)
        {
            try
            {
                getAdmissionById_Result objadm = new getAdmissionById_Result();

                objadm = objAdmOp.GetAdminssionById(Admissionid);
                txtAdmissionNo.Text = objadm.AdmissionNo;
                txtAdmissionDate.Text = objadm.AdmissionDate_S;
                txtRegNo.Text = objadm.RegNo;
                txtFirstName.Text = objadm.fname;
                txtLastName.Text = objadm.Lname;
                txtMiddelName.Text = objadm.Mname;
                txtAdress.InnerText = objadm.Address;
                txtMobileF.Text = objadm.MobileF;
                txtMobileH.Text = objadm.MobileH;
                txtMobileP.Text = objadm.MobileP;
                ddlArea.SelectedValue = Convert.ToString(objadm.AreId);
                txtQualification.Text = objadm.QualificationId;
                ddlStream.SelectedValue = Convert.ToString(objadm.StreamId);
                ddloccupation.SelectedValue = Convert.ToString(objadm.OccupationId);

                string[] courseId = Convert.ToString(objadm.CourseId).Split(',');
                foreach (ListItem item in ddlCourse.Items)
                {
                    foreach (var id in courseId)
                    {
                        if (item.Value == id)
                        {
                            item.Selected = true;
                        }
                    }

                }
                txtSchoolName.Text = objadm.SchoolName;
                txtBirthDate.Text = objadm.BirthDate_S;
                txtAge.Text = Convert.ToString(objadm.Age);
                txtFromTime.Text = objadm.PreferTimeFrom;
                txtToTime.Text = objadm.PreferTimeTO;
                txtRemark.InnerText = objadm.Remark;
                txtTotalFees.Text = Convert.ToString(objadm.TotalFees);
                txtDisCount.Text = Convert.ToString(objadm.DisCount);
                txtNetFees.Text = Convert.ToString(objadm.NetFees);
                txtNoofInstallment.Text = Convert.ToString(objadm.NoOfInstallment);
                int NoofInstallment = Convert.ToInt32(txtNoofInstallment.Text);
                bindDdlInstallment(NoofInstallment);
                txtNoofInstallment_TextChanged(NoofInstallment);
                List<string> InstallmentDatetotal = Request.Form.AllKeys.Where(key => key.Contains("txtdateInstallment")).ToList();
                List<string> InstallmentRstotal = Request.Form.AllKeys.Where(key => key.Contains("txtrdInstallment")).ToList();

                foreach (TextBox textBox in pnlInstallmentBoxes.Controls.OfType<TextBox>())
                {

                    if (textBox.ID == "txtdateInstallment1")
                    {
                        textBox.Text = Convert.ToString(objadm.Installment1Date_S);
                    }
                    if (textBox.ID == "txtrdInstallment1")
                    {
                        textBox.Text = Convert.ToString(objadm.Installment1Rs);
                    }
                    if (textBox.ID == "txtdateInstallment2")
                    {
                        textBox.Text = Convert.ToString(objadm.Installment2Date_S);
                    }
                    if (textBox.ID == "txtrdInstallment2")
                    {
                        textBox.Text = Convert.ToString(objadm.Installment2Rs);
                    }
                    if (textBox.ID == "txtdateInstallment3")
                    {
                        textBox.Text = Convert.ToString(objadm.Installment3Date_S);
                    }
                    if (textBox.ID == "txtrdInstallment3")
                    {
                        textBox.Text = Convert.ToString(objadm.Installment3Rs);
                    }
                    if (textBox.ID == "txtdateInstallment4")
                    {
                        textBox.Text = Convert.ToString(objadm.Installment4Date_S);
                    }
                    if (textBox.ID == "txtrdInstallment4")
                    {
                        textBox.Text = Convert.ToString(objadm.Installment4Rs);
                    }
                    if (textBox.ID == "txtdateInstallment5")
                    {
                        textBox.Text = Convert.ToString(objadm.Installment5Date_S);
                    }
                    if (textBox.ID == "txtrdInstallment5")
                    {
                        textBox.Text = Convert.ToString(objadm.Installment5Rs);
                    }
                }


            }
            catch (Exception ex)
            {
                com.Loginsert(HttpContext.Current.Request.Url.AbsolutePath, "bindAdmissionDetails", ex.StackTrace, ex.Message);
            }
            

        }

        protected void btnAddInstallment_Click(object sender, EventArgs e)
        {
            List<string> keys = Request.Form.AllKeys.Where(key => key.Contains("txtrdInstallment")).ToList();
            int intallment = keys.Count;

            if (intallment == 9) {
                btnAddInstallment.Visible = false;
            }
            txtNoofInstallment.Text = Convert.ToString(intallment + 1);
            AddNoofInstallment(intallment);

        }

        protected void delInstallment_Click(object sender, EventArgs e)
        {
            //List<string> keys = Request.Form.AllKeys.Where(key => key.Contains("txtrdInstallment")).ToList();
            //int intallment = keys.Count;
            //ContentPlaceHolder cph = (ContentPlaceHolder)this.Master.FindControl("ContentPlaceHolder1");
            //Panel pnlInstallmentBoxes = (Panel)cph.FindControl("pnlInstallmentBoxes");
            //pnlInstallmentBoxes.Controls[intallment].Dispose();
        }

        protected void ddlCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal totalfees = 0;
            foreach (ListItem item in ddlCourse.Items)
            {
                if (item.Selected)
                {
                    int courseid = Convert.ToInt32(item.Value);
                    aspccEntities objdb = new aspccEntities();
                    var coursedetails = objdb.Courses.Where(x => x.Id == courseid).FirstOrDefault();
                    if (coursedetails != null)
                    {
                        totalfees =+ (totalfees + coursedetails.Fee);
                    }
                }
            }

            txtTotalFees.Text = Convert.ToString(totalfees);
            txtNetFees.Text = Convert.ToString(totalfees);
            List<string> keys = Request.Form.AllKeys.Where(key => key.Contains("txtrdInstallment")).ToList();
            int intallment = keys.Count;
            if (intallment == 0)
            {
                txtDisCount.Text = "0";
                btnAddInstallment_Click(sender, e);
            }

        }

        public void bindDdlInstallment(int totalIntallments) {
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("value", typeof(string));

            for (int i = 0; i < totalIntallments; i++)
            {
                int intallment = i + 1;
                table.Rows.Add(intallment, Convert.ToString(intallment));
            }
            ddlInstallment.DataSource = table;
            ddlInstallment.DataTextField = "value";
            ddlInstallment.DataValueField = "Id";
            ddlInstallment.DataBind();
            ddlInstallment.SelectedValue = "1";
        }
        protected void btnPrint_Click(object sender, EventArgs e)
        {
            int InstallmentNo = Convert.ToInt32(ddlInstallment.SelectedValue);
            if (Request.QueryString["id"] != null)
            {
                string addmistionid = Request.QueryString["id"].ToString();
                Response.Redirect("PrintReceipt.aspx?id="+ addmistionid + "&InstallmentNo="+ InstallmentNo);
               
            }

        }
    }
}
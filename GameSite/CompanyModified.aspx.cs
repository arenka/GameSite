using GameSite.Data.Entity;
using GameSite.Ioc;
using GameSite.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameSite
{
    public partial class CompanyModified : System.Web.UI.Page
    {
        private readonly ICompanyService _companyService;
        public CompanyModified()
        {
            _companyService = Bootstrapper.GetService<ICompanyService>();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["Id"].ToString();
                Company company = _companyService.GetById(int.Parse(id));

                txtID.Value = company.Id.ToString();
                txtName.Value = company.Name;
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            string id = txtID.Value;
            Company company = _companyService.GetById(int.Parse(id));
            company.Name = txtName.Value;
            _companyService.Update(company);
            Response.Redirect("/Companies.aspx");
        }
    }
}
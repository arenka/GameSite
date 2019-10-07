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
    public partial class CompanyDeleted : System.Web.UI.Page
    {
        private readonly ICompanyService _companyService;
        public CompanyDeleted()
        {
            _companyService = Bootstrapper.GetService<ICompanyService>();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"].ToString();
            Company company = _companyService.GetById(int.Parse(id));
            txtHidden.Value = company.Id.ToString();
        }

        protected void btnCompanyDeleted_Click(object sender, EventArgs e)
        {
            string id = txtHidden.Value;
            Company company = _companyService.GetById(int.Parse(id));
            _companyService.Delete(company);
            Response.Redirect("/Companies.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Companies.aspx");
        }
    }
}
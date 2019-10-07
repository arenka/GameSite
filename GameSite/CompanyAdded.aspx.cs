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
    public partial class CompanyAdded : System.Web.UI.Page
    {
        private readonly ICompanyService _companyService;
        public CompanyAdded()
        {
            _companyService = Bootstrapper.GetService<ICompanyService>();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.Name = txtName.Value;
            _companyService.Insert(company);
            Response.Redirect("/Default.aspx");
        }
    }
}
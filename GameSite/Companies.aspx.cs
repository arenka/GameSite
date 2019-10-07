using GameSite.Data.Entity;
using GameSite.Ioc;
using GameSite.Service.Services;
using System;

namespace GameSite
{
    public partial class Companies : System.Web.UI.Page
    {
        private readonly ICompanyService _companyService;
        public Companies()
        {
            _companyService = Bootstrapper.GetService<ICompanyService>();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var company = _companyService.GetAll();
            rptCompany.DataSource = company;
            rptCompany.DataBind();
        }
    }
}
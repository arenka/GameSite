using System;
using System.Collections.Generic;
using System.Web.UI;
using GameSite.Data.Entity;
using GameSite.Ioc;
using GameSite.Service.Services;

namespace GameSite
{
    public partial class SiteMaster : MasterPage
    {
        private readonly ICompanyService _companyService;
        private readonly ICategoryService _categoryService;

        public SiteMaster()
        {
            _companyService = Bootstrapper.GetService<ICompanyService>();
            _categoryService = Bootstrapper.GetService<ICategoryService>();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Company> company = _companyService.GetAll();
            List<Category> category = _categoryService.GetAll();
            rptCompanies.DataSource = company;
            rptCategories.DataSource = category;
            rptCompanies.DataBind();
            rptCategories.DataBind();

            if (Session["User"]!=null)
            {
                userLink.HRef = "/UserDetails.aspx?id=" + Session["UserId"];
                lblUser.InnerText = Session["Username"].ToString();
                lblRegister.InnerText = "Çıkış Yap";
                registerLink.HRef = "/Logout.aspx";
            }
            else
            {
                userLink.HRef = "/LoginPage.aspx";
                lblUser.InnerText = "Kullanıcı Girişi";
                registerLink.HRef = "/Register.aspx";
                lblRegister.InnerText = "Kayıt Ol";
                lblAdmin.InnerText = "İstatistikler";
                AdminPanel.HRef = "/Admin.aspx";
            }
          
        }
    }
}
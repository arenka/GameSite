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
    public partial class Games : System.Web.UI.Page
    {
        private readonly IProductService _productService;
        public Games()
        {
            _productService = Bootstrapper.GetService<IProductService>();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var company = _productService.GetAll();
            rptCompany.DataSource = company;
            rptCompany.DataBind();
        }
    }
}
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
    public partial class Categories : System.Web.UI.Page
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        public Categories()
        {
            _categoryService = Bootstrapper.GetService<ICategoryService>();
            _productService = Bootstrapper.GetService<IProductService>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            var category = _categoryService.GetAll();
            var product = _productService.GetAll();
            if (Request.QueryString["Id"] == null)
            {
                rptCompany.DataSource = category;
                rptCompany.DataBind();
            }
            else
            {
                string id = Request.QueryString["Id"].ToString();
                var categoryProduct = product.Where(_ => _.CategoryId.ToString() == id);
                rptCompany.DataSource = categoryProduct;
                rptCompany.DataBind();
            }
           
        }
    }
}
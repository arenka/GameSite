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
    public partial class GameDeleted : System.Web.UI.Page
    {
        private readonly IProductService _productService;
        public GameDeleted()
        {
            _productService = Bootstrapper.GetService<IProductService>();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"].ToString();
            Product product = _productService.GetById(int.Parse(id));
            txtHidden.Value = product.Id.ToString();

        }

        protected void btnProductDeleted_Click(object sender, EventArgs e)
        {
            string id = txtHidden.Value;
            Product product = _productService.GetById(int.Parse(id));
            _productService.Delete(product);
            Response.Redirect("/Default.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }
    }
}
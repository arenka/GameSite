using System;
using System.Globalization;
using GameSite.Data.Entity;
using GameSite.Ioc;
using GameSite.Service.Services;

namespace GameSite
{
    public partial class GameDetails : System.Web.UI.Page
    {
        private readonly IProductService _productService;

        public GameDetails()
        {
            _productService = Bootstrapper.GetService<IProductService>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"].ToString();
            using (GameDbEntities context = new GameDbEntities())
            {
                Product product = _productService.GetById(int.Parse(id));

                lblGame.Text = product.Name;
                lblCompany.Text = product.Company.Name;
                lblPrice.Text = (product.Price).ToString(CultureInfo.InvariantCulture) + " TL";
                lblCategory.Text = product.Category.Name;
            }
        }
    }
}
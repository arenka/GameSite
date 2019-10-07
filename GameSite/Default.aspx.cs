using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameSite.Data.Entity;
using GameSite.Ioc;
using GameSite.Service.Services;

namespace GameSite
{
    public partial class _Default : Page
    {
        private readonly IProductService _productService;

        public _Default()
        {
            _productService = Bootstrapper.GetService<IProductService>();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> game = _productService.GetAll();
            rptGames.DataSource = game;
            rptGames.DataBind();
        }

        protected void GameLiked_Click(object sender, EventArgs e)
        {
            
        }
    }
}
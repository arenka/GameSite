using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using GameSite.Data.Entity;
using GameSite.Ioc;
using GameSite.Service.Services;


namespace GameSite
{
    public partial class GameAdded : System.Web.UI.Page
    {
        private IGameService _gameService;
        private readonly ICompanyService _companyService;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public GameAdded()
        {
            _gameService = Bootstrapper.GetService<IGameService>();
            _companyService = Bootstrapper.GetService<ICompanyService>();
            _categoryService = Bootstrapper.GetService<ICategoryService>();
            _productService = Bootstrapper.GetService<IProductService>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Company> companies = _companyService.GetAll();
                List<Category> categories = _categoryService.GetAll();
                foreach (var company in companies)
                {
                    ddlCompany.Items.Add(new ListItem { Text = (company.Name), Value = (company.Id.ToString()) });
                }
                foreach (var category in categories)
                {
                    ddlCategory.Items.Add(new ListItem { Text = (category.Name), Value = (category.Id.ToString()) });
                }
            }
            
           

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
           
            Product product = new Product();
            try
            {

                product.Name = txtName.Value;
                product.Price = double.Parse(txtPrice.Value);
                product.Stock = int.Parse(txtStock.Value);
                product.CategoryId = int.Parse(ddlCategory.SelectedValue);
                product.CompanyId = int.Parse(ddlCompany.SelectedValue);
                _productService.Insert(product);
                Response.Redirect("/Default.aspx");
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnKayıtOl_Click(object sender, EventArgs e)
        {
           
        }
    }
}
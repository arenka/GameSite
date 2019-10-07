using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using GameSite.Data.Entity;
using GameSite.Ioc;
using GameSite.Service.Services;

namespace GameSite
{
    public partial class GameModified : System.Web.UI.Page
    {


        private readonly ICompanyService _companyService;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public GameModified()
        {
            _categoryService = Bootstrapper.GetService<ICategoryService>(); 
            _companyService = Bootstrapper.GetService<ICompanyService>();
            _productService = Bootstrapper.GetService<IProductService>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            string id = Request.QueryString["Id"];
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
            Product product = _productService.GetById(int.Parse(id));

            txtID.Value = product.Id.ToString();
            txtName.Value = product.Name;
            txtPrice.Value = product.Price.ToString();
            txtStock.Value = product.Stock.ToString();
            ddlCategory.SelectedValue = product.CategoryId.ToString();
            ddlCompany.SelectedValue = product.CompanyId.ToString();


        }

        protected void btnModified_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Value;
                Product product = _productService.GetById(int.Parse(id));
                product.Name = txtName.Value;
                product.Price = int.Parse(txtPrice.Value);
                product.Stock = int.Parse(txtStock.Value);
                product.CategoryId = int.Parse(ddlCategory.SelectedValue);
                product.CompanyId = int.Parse(ddlCompany.SelectedValue);
                _productService.Update(product);
                Response.Redirect("/Default.aspx");
            }
            catch (Exception ex)
            {

                lblUyari.InnerText = ex.Message;

            }
        }
    }
}
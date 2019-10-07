using System;
using GameSite.Data.Entity;
using GameSite.Ioc;
using GameSite.Service.Services;

namespace GameSite
{
    public partial class Register : System.Web.UI.Page
    {
        private readonly IUserService _userService;

        public Register()
        {
            _userService = Bootstrapper.GetService<IUserService>();

        }

       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKayıtOl_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                user.FirstName = txtFirstName.Value;
                user.LastName = txtLastName.Value;
                user.UserName = txtUsername.Value;
                user.Email = txtEmail.Value;
                user.Password = int.Parse(txtPassword.Value);

                _userService.Insert(user);

                Response.Redirect("/Default.aspx");
            }
            catch (Exception ex)
            {

                lblUyari.InnerText = ex.Message;
            }
        }
    }
}
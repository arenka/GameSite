using System;
using GameSite.Data.Entity;
using GameSite.Ioc;
using GameSite.Service.Services;

namespace GameSite
{
    public partial class LoginPage : System.Web.UI.Page
    {
        private readonly IUserService _userService;

        public LoginPage()
        {
            _userService = Bootstrapper.GetService<IUserService>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                Response.Redirect("Default.aspx");
            }

            if (IsPostBack)
            {
                string userName = txtUserName.Value;
                string password = txtPassword.Value;

                using (GameDbEntities context = new GameDbEntities())
                {
                    User user = _userService.GetByUsernameAndPassword(userName, password);//context.User.Where(i => i.UserName == i.UserName  && i.Password.ToString() == password).FirstOrDefault();
                    if (user != null)
                    {
                        Session["User"] = user;
                        Session["Username"] = user.UserName;
                        Session["UserId"] = user.Id;
                        Response.Redirect("/LoginPage.aspx");
                    }
                    else
                    {
                        lblUyari.InnerText = "Kullanici Adı veya Şifre Hatalı!!!";
                    }


                }
            }
          
        }
    }
}
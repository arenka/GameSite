using System;
using GameSite.Data.Entity;
using GameSite.Ioc;
using GameSite.Service.Services;

namespace GameSite
{
    public partial class UserDetails : System.Web.UI.Page
    {
        private readonly IUserService _userService;

        public UserDetails()
        {
            _userService = Bootstrapper.GetService<IUserService>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {


            string id = Request.QueryString["Id"].ToString();



            User user = _userService.GetById(int.Parse(id));

            lblUser.Text = user.FirstName;
            lblLast.Text = user.LastName;
            lblEmail.Text = user.Email;
            lblUsername.Text = user.UserName;


            btnModified.HRef = "/UserModified.aspx?Id=" + id;
            btnDeleted.HRef = "/UserDeleted.aspx?Id=" + id;

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }
    }
}
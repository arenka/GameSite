using System;
using GameSite.Data.Entity;
using GameSite.Ioc;
using GameSite.Service.Services;

namespace GameSite
{
    public partial class UserDeleted : System.Web.UI.Page
    {
        private readonly IUserService _userService;

        public UserDeleted()
        {
            _userService = Bootstrapper.GetService<IUserService>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"].ToString();
            User user = _userService.GetById(int.Parse(id));
            txtHidden.Value = user.Id.ToString();
        }

        protected void btnUserDeleted_Click(object sender, EventArgs e)
        {
            string id = txtHidden.Value;
            User deletedUser = _userService.GetById(int.Parse(id));
            _userService.Delete(deletedUser);
            Response.Redirect("/Default.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }
    }
}
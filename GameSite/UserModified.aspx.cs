using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using GameSite.Data.Entity;
using GameSite.Ioc;
using GameSite.Service.Services;

namespace GameSite
{
    public partial class UserModified : System.Web.UI.Page
    {
        private readonly IUserService _userService;

        public UserModified()
        {
           _userService =  Bootstrapper.GetService<IUserService>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["Id"].ToString();
                User user = _userService.GetById(int.Parse(id));

                txtID.Value = user.Id.ToString();
                txtName.Value = user.FirstName;
                txtLast.Value = user.LastName;
                txtUsername.Value = user.UserName;
                lblEmail.Text = user.Email;
                txtPassword.Value = user.Password.ToString();
                txtAdmin.Value = user.isAdmin.ToString();
            }
        }
        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Value;
                string isAdmin = txtAdmin.Value;
                User lastUser = _userService.GetById(int.Parse(id));

                lastUser.FirstName = txtName.Value;
                lastUser.LastName = txtLast.Value;
                lastUser.UserName = txtUsername.Value;
                lastUser.Email = lblEmail.Text;
                lastUser.Password =int.Parse(txtPassword.Value);
                lastUser.isAdmin = bool.Parse(isAdmin);
                _userService.Update(lastUser);
                Response.Redirect("UserDetails.aspx?Id="+int.Parse(id));
            }
            catch (Exception ex)
            {

                lblUyari.InnerText = ex.Message;
            }
          
        }
    }
}
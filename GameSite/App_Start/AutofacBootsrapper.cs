using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Web;
using Autofac;
using GameSite.Data.Entity;
using GameSite.Data.Repositories;
using GameSite.Data.Repositories.Impl;
using GameSite.Ioc;
using GameSite.Service.Services;
using GameSite.Service.Services.Impl;

namespace GameSite.App_Start
{
    public class AutofacBootsrapper
    {
        public static void Register()
        {
            Bootstrapper.ScopeProvider = new WebFormProvider();
            Bootstrapper.InitializeBuilder();

            //Bootstrapper.Builder.Extensions().SqlConnection("NewspaperContext");
            //Bootstrapper.Builder.Register(c => new NDD.DbConnectionFactory
            //{
            //    MembershipConnection = c.ResolveKeyed<IDbConnection>(ConnectionName.Membership),
            //    MembershipLogConnection = c.ResolveKeyed<IDbConnection>(ConnectionName.MembershipLog),
            //    NewspaperConnection = c.Resolve<IDbConnection>()
            //});


            Bootstrapper.Builder.RegisterGeneric(typeof(Repository<>))
                .As(typeof(IRepository<>));

            Bootstrapper.Builder.RegisterType<CategoryService>().As<ICategoryService>();
            Bootstrapper.Builder.RegisterType<CompanyService>().As<ICompanyService>();
            Bootstrapper.Builder.RegisterType<GameService>().As<IGameService>();
            Bootstrapper.Builder.RegisterType<ProductService>().As<IProductService>();
            Bootstrapper.Builder.RegisterType<UserService>().As<IUserService>();
            Bootstrapper.Builder.RegisterType<OrderService>().As<IOrderService>();


            Bootstrapper.SetAutofacContainer();
        }
    }
}
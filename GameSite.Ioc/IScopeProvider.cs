﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace GameSite.Ioc
{
    public interface IScopeProvider
    {
        ILifetimeScope Scope();
    }
}

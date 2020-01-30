﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Udemy.Dating.Api.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;

        public static class Identity
        {
            public const string Login = Base + "/login";
            public const string Register = Base + "/register";
        }

        public static class Azure
        {
            public const string Base = ApiRoutes.Base + "azure";
            public const string KeyVault = Root + "keyvault";
        }
    }
}

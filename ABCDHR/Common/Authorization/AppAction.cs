﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Authorization
{
    public static class AppAction
    {
        public const string Create = nameof(Create);
        public const string Read = nameof(Read);
        public const string Delete = nameof(Delete);
        public const string Update = nameof(Update);
    }
}

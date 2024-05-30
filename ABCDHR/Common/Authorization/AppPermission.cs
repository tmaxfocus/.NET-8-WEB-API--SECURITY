using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Authorization
{
    public record AppPermission(string Feature,string Action, string Group, string Description, bool isBasic = false)
    {
        public string Name { get; set; }

        public static string NameFor(string feature, string action) => $"Permissions.{feature}.{action}";
   }

    public class AppPermissions
    {
        private static readonly AppPermission[] _all = new AppPermission[]
        {
            new(AppFeature.Users,AppAction.Create, AppRoleGroup.SystemAccess, "Create Users"),
            new(AppFeature.Users,AppAction.Update, AppRoleGroup.SystemAccess, ",Update Users"),
            new(AppFeature.Users,AppAction.Read, AppRoleGroup.SystemAccess, "Read Users"),
            new(AppFeature.Users,AppAction.Delete, AppRoleGroup.SystemAccess, "Delete Users"),
        };
    }
}

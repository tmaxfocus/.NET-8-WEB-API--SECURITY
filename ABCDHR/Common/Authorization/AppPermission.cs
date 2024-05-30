﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

           // new(AppFeature.UserRoles,AppAction.Create, AppRoleGroup.SystemAccess, "Create User Roles"),
            new(AppFeature.UserRoles,AppAction.Read, AppRoleGroup.SystemAccess, "Read User Roles"),
            new(AppFeature.UserRoles,AppAction.Update, AppRoleGroup.SystemAccess, ",Update User Roles"),
           
           // new(AppFeature.UserRoles,AppAction.Delete, AppRoleGroup.SystemAccess, "Delete User Roles"),

            new(AppFeature.Employees,AppAction.Create, AppRoleGroup.ManagementHierarchy, "Create Employees"),
            new(AppFeature.Employees,AppAction.Update, AppRoleGroup.ManagementHierarchy, ",Update Employees"),
            new(AppFeature.Employees,AppAction.Read, AppRoleGroup.ManagementHierarchy, "read Employees", isBasic: true),
            new(AppFeature.Employees,AppAction.Delete, AppRoleGroup.ManagementHierarchy, "Delete Employees"),

            new(AppFeature.Roles,AppAction.Create, AppRoleGroup.SystemAccess, "Create Roles"),
            new(AppFeature.Roles,AppAction.Update, AppRoleGroup.SystemAccess, ",Update Roles"),
            new(AppFeature.Roles,AppAction.Read, AppRoleGroup.SystemAccess, "Read Roles"),
            new(AppFeature.Roles,AppAction.Delete, AppRoleGroup.SystemAccess, "Delete Roles"),

            new(AppFeature.RoleClaims,AppAction.Read, AppRoleGroup.SystemAccess, "view role claims/permission"),
            new(AppFeature.RoleClaims,AppAction.Update, AppRoleGroup.SystemAccess, "update role claims/permission"),
        };

        public static IReadOnlyList<AppPermission> AdminPermissions { get; } = new ReadOnlyCollection<AppPermission>(_all.Where(p => !p.isBasic).ToArray());

        public static IReadOnlyList<AppPermission> BasicPermission { get; } = new ReadOnlyCollection<AppPermission>(_all.Where(p => p.isBasic).ToArray());
    }
}

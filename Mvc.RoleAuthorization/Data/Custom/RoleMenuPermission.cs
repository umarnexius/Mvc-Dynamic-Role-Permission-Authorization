using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc.RoleAuthorization.Data.Custom
{
    [Table(name: "AspNetRoleMenuPermission")]
    public class RoleMenuPermission
    {
        public int RoleId { get; set; }

        public int NavigationMenuId { get; set; }

        public NavigationMenu? NavigationMenu { get; set; }
    }
}
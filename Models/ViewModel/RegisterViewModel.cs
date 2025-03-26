using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace ERPSystem.Models.ViewModel
{
    public class RegisterViewModel
    {
        [Required] public string FullName { get; set; }
        [Required] public string Email { get; set; }
        [Required, DataType(DataType.Password)] public string Password { get; set; }
    }

    public class AssignRoleViewModel
    {
        public string UserId { get; set; }
        public List<SelectListItem> Roles { get; set; }
        public string SelectedRole { get; set; }
    }
}

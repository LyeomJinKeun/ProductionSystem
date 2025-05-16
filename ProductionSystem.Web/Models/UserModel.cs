using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductionSystem.Web.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "사용자 계정을 입력해주세요.")]
        [Display(Name = "사용자 계정")]
        public string Account { get; set; } = string.Empty;

        [Required(ErrorMessage = "암호를 입력해주세요.")]
        [Display(Name = "사용자 암호")]
        public string Password { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "사용자 이름을 입력해주세요.")]
        [Display(Name = "사용자 이름")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "사용자 권한을 입력해주세요.")]
        [Display(Name = "사용자 권한")]
        public string UserType { get; set; } = string.Empty;
        public string AllowApp { get; set; } = string.Empty;
        public string AllowView { get; set; } = string.Empty;
    }
}
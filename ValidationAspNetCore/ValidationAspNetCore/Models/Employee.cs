using System.ComponentModel.DataAnnotations;

namespace ValidationAspNetCore.Models
{
    public class Employee
    {
        [Display(Name ="Họ và tên")]
        [MaxLength(10,ErrorMessage ="Tên phải lớn hơn 10 ký tự")]
        public string FullName { get; set; }

        [Display(Name = "Tuổi")]
        [Required(ErrorMessage = "Không để trống!")]
        [Range(18, 60, ErrorMessage = "Tuổi phải từ 18 đến 60 !")]
        public int Age { get; set; }
    }
}

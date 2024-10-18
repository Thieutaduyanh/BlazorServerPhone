using System.ComponentModel.DataAnnotations;
namespace BlazorServerApp.Data
{
    public class User
    {
        public int UserId { get; set; }

        [Required (ErrorMessage ="Please fill fullname")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string UserEmail { get; set; }

        [Required]
        public string UserPassword { get; set; }
        public int UserLevel { get; set; }
        public string UserAvatar { get; set; }
        public int IsDeleted { get; set; }
    }
}

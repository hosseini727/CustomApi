using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public  class User : BaseEntity
    {
        public User()
        {
            IsActive = true;
        }
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset LastLoginDate { get; set; }
        public ICollection<Post>Posts { get; set; }
    }

    public enum GenderType
    {
        [Display(Name = "مرد")]
        Male = 1,
        [Display(Name = "زن")]
        FEmael = 2, 
    }
}

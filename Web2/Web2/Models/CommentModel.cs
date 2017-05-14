using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web2.Models
{
    public class CommentModel
    {
        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        [Display(Name = "Имя")]            
        public string Name { get; set; }

       [Required(ErrorMessage = "Вы ничего не ввели")]            
       [Display(Name = "Комментарий")]
       public string Text{ get; set; }       
    }

    public class CommentContext : DbContext
    {
        public CommentContext()
            :base("DefaultConnection (Web2)")
        { }
        public DbSet<CommentModel> CommentModels { get; set; }
    }
}
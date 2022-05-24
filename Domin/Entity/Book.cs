using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class Book
    {
        public Guid Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.ResourceData), ErrorMessageResourceName = ("BookName"))]
        [MaxLength(20, ErrorMessageResourceType = typeof(Resources.ResourceData), ErrorMessageResourceName = "Maxlength")]
        [MinLength(4, ErrorMessageResourceType = typeof(Resources.ResourceData), ErrorMessageResourceName = "MiniLength")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessageResourceType =typeof(Resources.ResourceData),ErrorMessageResourceName = "AutherName")]
        [MaxLength(20, ErrorMessageResourceType =typeof(Resources.ResourceData),ErrorMessageResourceName ="Maxlength")]
        [MinLength(3,ErrorMessageResourceType =typeof(Resources.ResourceData),ErrorMessageResourceName ="MiniLength")]
        public string? Auther { get; set; }
        public string? ImageName { get; set; }
        public string? FileName { get; set; }
        public string? Desription { get; set; }
        public bool Pubilish { get; set; }

        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

        public Guid SubCategoryId { get; set; }
        [ForeignKey("SubCategoryId")]
        public SubCategory? SubCategory { get; set; }

        public int CurrentState { get; set; }



    }
}

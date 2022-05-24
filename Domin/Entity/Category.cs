using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required(ErrorMessageResourceType = typeof(Resources.ResourceData),ErrorMessageResourceName =("CategoryName"))]
        [MaxLength(20,ErrorMessageResourceType =typeof(Resources.ResourceData),ErrorMessageResourceName ="Maxlength")]
        [MinLength(4,ErrorMessageResourceType =typeof(Resources.ResourceData),ErrorMessageResourceName ="MiniLength")]
        public string Name { get; set; } = string.Empty;
        [Display(Name ="Descroption")]
        public string? Description { get; set; }
        [Display(Name ="Creation Date")]
        public int CurrentState { get; set; }
        public DateTime Date { get; set; }

       




    }
}

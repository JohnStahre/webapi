using System.ComponentModel.DataAnnotations.Schema;

namespace WebAspNetMvc.Models
{
    public class Category
    {
        [Index(nameof(Name), IsUnique = true)]
        public class Category
        {

            public int Id { get; set; }

            public string Name { get; set; }

            public virtual ICollection<SubCategory> SubCategories { get; set; }
        }
    }
}

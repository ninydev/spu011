using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp2.Models.Shop
{
    public  class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }


        public Guid? ParentCategoryId { get; set; } // Если нету родителя (NULL)- это корень
        virtual public Category ParentCategory { get; set; }

        virtual public ICollection<Category> ChildCategories { get; set; }


    }
}

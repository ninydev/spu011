using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp2.Models
{
    public class Group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } // = Guid.NewGuid(); // Лучше в базе

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        // Отношение ко многим студентам
        public virtual ICollection<Student>? Students { get; set; }

        public override string ToString()
        {
            return this.Name;
        }

    }
}

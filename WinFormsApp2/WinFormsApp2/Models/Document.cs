using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp2.Models
{
    public class Document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } // = Guid.NewGuid(); // Лучше в базе

        [Required]
        public string Name { get; set; }

        // Хранение информации в самой базе данных
        public byte[] Data { get; set; }

        public virtual List<Student> Students { get; set; } = new List<Student>();
    }
}

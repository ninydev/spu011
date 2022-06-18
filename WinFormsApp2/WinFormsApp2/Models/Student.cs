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
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } // = Guid.NewGuid(); // Лучше в базе

        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(250)]
        // [Index(IsUnique = true)] // Не поддерживается в .Core  (EF6 будет работать)
        public string Email { get; set; }

        // Ссылка на файл (в стороннем хранилище)
        public string Avatar { get; set; }

        // Хранение информации в самой базе данных
        public byte[] Image { get; set; }

        public virtual List<Document> Documents { get; set; } = new List<Document>();

        // Отношение к конкретной одной группе
        public Guid? GroupId { get; set; } // Это можно было не писать
        // Это поле - для загрузки данных о группе
        public virtual Group? Group { get; set; }

        public override string ToString()
        {
            return this.Name;
        }


    }
}

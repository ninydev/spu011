using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class Author
    {

        public Guid Id { get; set; } // = Guid.NewGuid(); // Лучше в базе

        public string Title { get; set; }

        public int Level { get; set; } 

        virtual public ICollection<Post> Posts { get; set; }

        virtual public ICollection<Tag> Tags { get; set; }

        public override string ToString()
        {
            return this.Title;
        }
    }
}

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

        virtual public List<Post> Posts { get; set; }
    }
}

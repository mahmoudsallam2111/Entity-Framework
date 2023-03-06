using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lab02.Models
{
    internal class Auther
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public DateTime Hiredate { get; set; }

        public List<News> News { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lab02.Models
{
    internal class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Bref { get; set; }

        public DateTime datetime { get; set; }

        public int AutherId { get; set; }

        public virtual Auther Auther { get; set; }


          public  List<NewsDetail> Details { get; set; }
    }
}

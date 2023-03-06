using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lab02.Models
{
    internal class NewsDetail
    {
        public int Id { get; set; }

        public string description { get; set; }

        public string Photo { get; set; }
        public string Pdf { get; set; }
        public string Reference { get; set; }

        public int news_Id { get; set; }

        public virtual News news { get; set; }

        
    }
}

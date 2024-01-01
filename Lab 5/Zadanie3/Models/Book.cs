using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.Zadanie3.Interface;

namespace Lab5.Zadanie3.Models
{
    public class Book : IEntity<int>, IHasCreationTime
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
      
        public int PublishYear { get; set; }
    }
}

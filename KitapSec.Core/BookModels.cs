using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitapsec.Core
{
    public class Book:BaseModel
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
    }

    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

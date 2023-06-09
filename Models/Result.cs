using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class Result
    {
        [Key]
        public int Id { get; set; }
        public double Nr1 { get; set; }
        public double Nr2 { get; set; }
        public string Method { get; set; }
        public double Results { get; set; }
    }
}

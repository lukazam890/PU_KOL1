using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        public int ID { get; set; }
        public string Imie {  get; set; }
        public string Nazwisko { get; set; }
        public int? GrupaID { get; set; }
        [ForeignKey(nameof(GrupaID))]
        public Grupa? Grupa { get; set; }
    }
}

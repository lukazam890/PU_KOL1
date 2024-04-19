using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum TypAkcji
    {
        Usuwanie, 
        Edycja
    }
    public class Historia
    {
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int IdGrupy { get; set; }
        [ForeignKey(nameof(IdGrupy))]
        public Grupa Grupa { get; set; }
        public TypAkcji Typ_akcji { get; set; }
        public DateTime Data {  get; set; }
    }
}

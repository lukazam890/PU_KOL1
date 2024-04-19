using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class HistoriaResponseDTO
    {
        public int ID { get; init; }
        public string Imie { get; init; }
        public string Nazwisko { get; init; }
        public TypAkcji Typ_akcji { get; init; }
        public DateTime Data { get; init; }
    }
}

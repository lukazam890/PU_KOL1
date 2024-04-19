using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class StudentRequestDTO
    {
        public string Imie { get; init; }
        public string Nazwisko { get; init; }
        public int? GrupaID { get; init; }
    }
}

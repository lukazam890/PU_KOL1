using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class StudentResponseDTO
    {
        public int ID { get; init; }
        public string Imie { get; init; }
        public string Nazwisko { get; init; }
        public GrupaResponseDTO? Grupa { get; init; }
    }
}

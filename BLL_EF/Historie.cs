using BLL.DTO;
using BLL.ServiceInterfaces;
using DAL;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_EF
{
    public class Historie : IHistorie
    {
        private readonly StudenciContext _context;
        public Historie(StudenciContext context)
        {
            _context = context;
        }
        public IEnumerable<HistoriaResponseDTO> WyswietlHistorie(PaginationDTO stronnicowanie)
        {
            List<HistoriaResponseDTO> historia = new List<HistoriaResponseDTO>();
            _context.Historie.Include(his => his.Grupa)
                .Skip(stronnicowanie.LiczbaElementow * (stronnicowanie.NumerStrony - 1)).
                Take(stronnicowanie.LiczbaElementow).ToList().ForEach(h => historia.Add(new HistoriaResponseDTO
                {
                    ID = h.ID,
                    Imie = h.Imie,
                    Nazwisko = h.Nazwisko,
                    NazwaGrupy = h.Grupa.Nazwa,
                    Typ_akcji = h.Typ_akcji,
                    Data = h.Data,
                }));
            return historia;
        }
    }
}

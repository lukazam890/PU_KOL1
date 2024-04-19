using BLL.DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IHistorie
    {
        public IEnumerable<HistoriaResponseDTO> WyswietlHistorie(PaginationDTO stronnicowanie);
    }
}

using BLL.DTO;
using BLL.ServiceInterfaces;
using DAL;
using Microsoft.Data.SqlClient;
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
        private readonly string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudenciDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public Historie(StudenciContext context)
        {
            _context = context;
        }
        public IEnumerable<HistoriaResponseDTO> WyswietlHistorie(int liczbaElementow, int numerStrony)
        {
            List<HistoriaResponseDTO> historia = new List<HistoriaResponseDTO>();
            /*
            _context.Historie.Include(his => his.Grupa)
                .Skip(liczbaElementow * (numerStrony - 1)).
                Take(liczbaElementow).ToList().ForEach(h => historia.Add(new HistoriaResponseDTO
                {
                    ID = h.ID,
                    Imie = h.Imie,
                    Nazwisko = h.Nazwisko,
                    NazwaGrupy = h.Grupa.Nazwa,
                    Typ_akcji = h.Typ_akcji,
                    Data = h.Data,
                }));
            return historia;
            */
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "exec WyswietlHistorie " + liczbaElementow + ", " + numerStrony;
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    HistoriaResponseDTO historiaDTO = new HistoriaResponseDTO
                    {
                        ID = (int)reader["ID"],
                        Imie = reader["Imie"].ToString(),
                        Nazwisko = reader["Nazwisko"].ToString(),
                        NazwaGrupy = reader["NazwaGrupy"].ToString(),
                        Typ_akcji = (TypAkcji)reader["Typ_akcji"],
                        Data = (DateTime)reader["Data"]
                    };
                    historia.Add(historiaDTO);
                }
                reader.Close();
                sqlCommand.Connection.Close();
            }
            return historia;
        }
    }
}

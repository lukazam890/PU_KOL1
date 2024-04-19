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
    public class Students : IStudents
    {
        private readonly StudenciContext _context;
        public Students(StudenciContext context)
        {
            _context = context;
        }
        public void CreateStudent(StudentRequestDTO studentDTO)
        {
            Student student = new Student
            {
                Imie = studentDTO.Imie,
                Nazwisko = studentDTO.Nazwisko,
                GrupaID = studentDTO.GrupaID
            };
            _context.Studenci.Add(student);
            _context.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            Student? student = _context.Studenci.FirstOrDefault(s => s.ID == id);
            if (student != null)
            {
                _context.Studenci.Remove(student);
                _context.SaveChanges();
            }
        }

        public IEnumerable<StudentResponseDTO> GetAllStudents()
        {
            List<StudentResponseDTO> listaStudentow = new List<StudentResponseDTO>();
            _context.Studenci.Include(s => s.Grupa).ToList().ForEach(i => listaStudentow.Add(new StudentResponseDTO
            {
                ID = i.ID,
                Imie = i.Imie,
                Nazwisko = i.Nazwisko,
                Grupa = new GrupaResponseDTO { Id = i.Grupa.Id, Nazwa = i.Grupa.Nazwa }
            }));
            return listaStudentow;
        }

        public void UpdateStudent(int id, StudentRequestDTO studentDTO)
        {
            Student? student = _context.Studenci.FirstOrDefault(s => s.ID == id);
            if (studentDTO != null)
            {
                student.Imie = studentDTO.Imie;
                student.Nazwisko = studentDTO.Nazwisko;
                student.GrupaID = studentDTO.GrupaID;
                _context.SaveChanges();
            }
        }
    }
}

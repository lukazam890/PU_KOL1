using BLL.DTO;
using BLL.ServiceInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_EF
{
    public class Student : IStudent
    {
        private readonly DbContext _context;
        public Student(DbContext context)
        {
            _context = context;
        }
        public void CreateStudent(StudentRequestDTO student)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StudentResponseDTO> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(StudentResponseDTO student)
        {
            throw new NotImplementedException();
        }
    }
}

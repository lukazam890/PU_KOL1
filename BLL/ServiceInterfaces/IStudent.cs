using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IStudent
    {
        public void CreateStudent(StudentRequestDTO student);
        public void UpdateStudent(StudentResponseDTO student);
        public void DeleteStudent(int id);
        public IEnumerable<StudentResponseDTO> GetAllStudents();
    }
}

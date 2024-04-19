using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IStudents
    {
        public void CreateStudent(StudentRequestDTO studentDTO);
        public void UpdateStudent(int id, StudentRequestDTO studentDTO);
        public void DeleteStudent(int id);
        public IEnumerable<StudentResponseDTO> GetAllStudents();
    }
}

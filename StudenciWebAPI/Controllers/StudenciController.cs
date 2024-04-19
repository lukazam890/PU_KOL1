using BLL.DTO;
using BLL.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudenciWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudenciController : ControllerBase
    {
        private readonly IStudents _service;
        public StudenciController(IStudents service)
        {
            _service = service;
        }
        [HttpPost]
        public void CreateStudent(StudentRequestDTO studentDTO)
        {
            _service.CreateStudent(studentDTO);
        }
        [HttpDelete]
        public void DeleteStudent(int id)
        { 
            _service.DeleteStudent(id); 
        }
        [HttpGet]
        public IEnumerable<StudentResponseDTO> GetAllStudents()
        {
            return _service.GetAllStudents();
        }
        [HttpPut]
        public void UpdateStudent(int id, StudentRequestDTO studentDTO)
        {
            _service.UpdateStudent(id, studentDTO);
        }

    }
}

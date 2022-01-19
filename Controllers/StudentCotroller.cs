using Microsoft.AspNetCore.Mvc;
using SchoolApp.Data;
using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController
    {
        private readonly DataContext _dataContext;

        public StudentController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public List<Student> GetAll()
        {
            return _dataContext.Students.ToList();
        }

        [HttpGet("{id}")]
        public Student GetById(int id)
        {
            return _dataContext.Students.Find(id);
        }

        [HttpPost]
        public void Create(Student student)
        {
            _dataContext.Students.Add(student);
            _dataContext.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Update(int id, Student studentUpdate)
        {
            var student = _dataContext.Students.Find(id);

            student.Name = studentUpdate.Name;

            _dataContext.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var student = _dataContext.Students.Find(id);
            _dataContext.Remove(student);
            _dataContext.SaveChanges();
        }
    }
}

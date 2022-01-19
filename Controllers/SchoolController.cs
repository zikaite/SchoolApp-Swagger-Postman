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
    public class SchoolController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public SchoolController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
            public List<School> GetAll()
            {
                return _dataContext.Schools.ToList();
            }

            [HttpGet("{id}")]
            public School GetById(int id)
            {
                return _dataContext.Schools.Find(id);
            }

            [HttpPost]
            public void Create(School school)
            {
                _dataContext.Schools.Add(school);
                _dataContext.SaveChanges();
            }

            [HttpPut("{id}")]
            public void Update(int id, School schoolUpdate)
            {
                var school = _dataContext.Schools.Find(id);

                school.Name = schoolUpdate.Name;

                _dataContext.SaveChanges();
            }

            [HttpDelete("{id}")]
            public void Delete(int id)
            {
                var school = _dataContext.Schools.Find(id);
                _dataContext.Remove(school);
                _dataContext.SaveChanges();
            }
        
    }

}
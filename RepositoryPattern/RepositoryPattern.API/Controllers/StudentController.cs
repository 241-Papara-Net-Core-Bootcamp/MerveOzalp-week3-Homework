using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Business.Abstract;
using RepositoryPattern.Domain;
using RepositoryPattern.Domain.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;
        

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
            
        }

        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            var result = studentService.GetList();
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetById(int Id)
        {
            try
            {
                var result = studentService.GetById(Id);
               
                return Ok();
            }
            catch (System.Exception)
            {

                return BadRequest("Aranan Id'de kişi bulunamadı");
            }
            
           
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            try
            {
                studentService.Add(student);
            }
            catch (System.Exception)
            {

                return BadRequest("hatalı Giriş Yapıldı.");
            }
            
            return Ok("kişi eklendi.");
        }

        [HttpPut]
        public IActionResult Update(Student student)
        {
            try
            {
                studentService.Update(student);
            }
            catch (System.Exception)
            {

                return NotFound("Aranan kişi bulunamadı.");
            }
            
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            try
            {
                studentService.Delete(Id);
            }
            catch (System.Exception)
            {

                return BadRequest("Hatalı Id girişi");
            }

            return Ok("silme işlemi gerçekleşti.");
        }
    }
}


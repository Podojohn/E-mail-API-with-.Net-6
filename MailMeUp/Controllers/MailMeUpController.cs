﻿using Dtos;
using Microsoft.AspNetCore.Mvc;
using Models.Responses;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MailMeUp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MailMeUpController : ControllerBase
    {
        // GET: api/<MailMeUpController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MailMeUpController>/5
        [HttpPost]
        public ActionResult<EmailResponse> SendEmail(MailDto dto)
        {
            if (dto is null)
                return new BadRequestObjectResult(new EmailResponse() { Success = false, ErrorMessage = "No Data was given" });
            if (dto.To is null)
                return new BadRequestObjectResult(new EmailResponse() { Success = false, ErrorMessage = "No Receiver was provided" });
            if (dto.To.Count == 0)
                return new BadRequestObjectResult(new EmailResponse() { Success = false, ErrorMessage = "No Receiver was provided" });
            return null;
        }

        // POST api/<MailMeUpController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MailMeUpController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MailMeUpController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
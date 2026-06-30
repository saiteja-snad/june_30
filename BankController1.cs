using Asp.Versioning;
using Banking_Management_System.DTOS;
using Banking_Management_System.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Banking_Management_System.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class BankController1 : ControllerBase
    {
        private readonly IBankService _ser;

        public BankController1(IBankService ser)
        {
            _ser=ser;
        }

        //===================================================
        [HttpGet]
        public IActionResult Getall()
        {
           var r = _ser.GetAll();
            return Ok(r);
        }
        //==================================================
        [HttpGet("{id}")]
        public IActionResult Getid(int id)
        {
            var r = _ser.GetById(id);
            return Ok(r);
        }
        //=================================================
        [HttpPost]
        public IActionResult addBook(AddBankDto dto)
        {
            var r=_ser.AddBank(dto);
            return Ok(r);
           
        }
        //==============================================
        [HttpPut("{id}")]
        public IActionResult update(int id,UpdateBankDto dto)
        {
            var r = _ser.Updatebank(id, dto);
            return Ok(r);
        }
        //=============================================
        [HttpDelete("{id}")]
        public IActionResult deletebyid(int id)
        {
            var r = _ser.deletebank(id);
            return Ok(r);
        }
        //================================================
    }
}

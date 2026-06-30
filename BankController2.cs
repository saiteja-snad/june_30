using Asp.Versioning;
using Banking_Management_System.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Banking_Management_System.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("2.0")]
    public class BankController2 : ControllerBase
    {
        private readonly ILogger<BankController2> _logger;
        private readonly IBankService _ser;

        public BankController2(IBankService ser, ILogger<BankController2> logger )
        {
            _ser = ser;
            _logger = logger;
        }
        [HttpGet("pagination")]
        public IActionResult getpages(int pageno,int pagesize)
        {
            var r=_ser.GetPages(pageno,pagesize);
            return Ok(r);
        }

        //===================================================================
        [HttpGet("searchbyname")]
        public IActionResult serachbyname(string name)

        {

            _logger.LogInformation("Customer name searched");
            var r = _ser.searchname(name);
            return Ok(r);
        }
        //===================================================================
        [HttpGet("searchbybranch")]
        public IActionResult serachbybranch(string branch)
        {
            _logger.LogInformation("Customer branch searched");
            var r = _ser.searchBranch(branch);
            return Ok(r);
        }
        //===================================================================
        [HttpGet("searchbybalance")]
        public IActionResult serachbybalance(int balance)
        {
            _logger.LogInformation("Customer balance searched");
            var r = _ser.searchbybalance(balance);
            return Ok(r);
        }
        //===================================================================
        //===================================================================
        [HttpGet("searchbyaccounttype")]
        public IActionResult serachbyaccounttype(string type)
        {
            _logger.LogInformation("Customer accounttype searched");
            var r = _ser.searchAccountType(type);
            return Ok(r);
        }
        //===================================================================
        //===================================================================
        [HttpGet("searchbystatus")]
        public IActionResult serachbystatus(string status)
        {
            _logger.LogInformation("Customer  status  searched");
            var r = _ser.searchbystatus(status);
            return Ok(r);
        }
        //===================================================================

        [HttpGet("sortbyname")]
        public IActionResult sortbyname()
        {
            _logger.LogInformation("Customer name wise sort");
            var r = _ser.sortName();
            return Ok(r);
        }
        //==============================================

        [HttpGet("sortbybranch")]
        public IActionResult sortbybranch()
        {
            _logger.LogInformation("Customer branch wise sort");
            var r = _ser.sortBranch();
            return Ok(r);
        }
        //==============================================

        [HttpGet("sortbybalance")]
        public IActionResult sortbybalance()
        {
            _logger.LogInformation("Customer balance  wise sort");
            var r = _ser.sortbalance();
            return Ok(r);
        }
        //==============================================

        //==============================================
    }
}

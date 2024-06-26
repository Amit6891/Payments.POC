using Microsoft.AspNetCore.Mvc;
using PaymentsPOC.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PaymentsPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        // GET: api/<AccountsController>
        [HttpGet]
        public async Task <IActionResult> Get()
        {
            Random rand = new Random();
            var accounts = AllAccounts();
            var account = accounts[rand.Next(accounts.Count)];
            return Ok(account);
        }

        // GET api/<AccountsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AccountsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AccountsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccountsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private List<Account> AllAccounts()
        {
            return new List<Account>()
            {
                new Account() { Id = 1, Name = "Vodafone 123", FinalSettlement = "123456", RefNum = "1234567890", Amount = 486.52m, Email="test123@test.com" },
                new Account() { Id = 1, Name = "Vodafone XYZ", FinalSettlement = "567890", RefNum = "1234567890", Amount = 99.99m, Email="xyz123@test.com" },
                new Account() { Id = 1, Name = "Vodafone 999", FinalSettlement = "010101", RefNum = "1234567890", Amount = 86.5m, Email="test999@test.com" },
                new Account() { Id = 1, Name = "Vodafone ABC", FinalSettlement = "999999", RefNum = "1234567890", Amount = 46.52m, Email="abc123@test.com" },
                new Account() { Id = 1, Name = "Vodafone TEST", FinalSettlement = "222222", RefNum = "1234567890", Amount = 1486.52m, Email="testing111@test.com" },
            };
        } 
    }
}

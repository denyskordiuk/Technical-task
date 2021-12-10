using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebAPIApp.Models;
using System.Threading.Tasks;
using Technical_task.Models;

namespace WebAPIApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        AccountContext db;
        public ValuesController(AccountContext context)
        {
            db = context;
            if (!db.Accounts.Any())
            {
                db.Accounts.Add(new Account { Name = "John", Id = 1 });
                db.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> Get()
        {
            return await db.Accounts.ToListAsync();
        }

        // GET api/
        [HttpGet("{id}")]
        public async Task<ActionResult<Account>> Get(int id)
        {
            Account account = await db.Accounts.FirstOrDefaultAsync(x => x.Id == id);
            if (account == null)
                return NotFound();
            return new ObjectResult(account);
        }

        // POST api/
        [HttpPost]
        public async Task<ActionResult<Account>> Post(Account account)
        {
            if (account == null)
            {
                return BadRequest();
            }

            db.Accounts.Add(account);
            await db.SaveChangesAsync();
            return Ok(account);
        }

        // PUT api/users/
        [HttpPut]
        public async Task<ActionResult<Account>> Put(Account account)
        {
            if (account == null)
            {
                return BadRequest();
            }
            if (!db.Accounts.Any(x => x.Id == account.Id))
            {
                return NotFound();
            }

            db.Update(account);
            await db.SaveChangesAsync();
            return Ok(account);
        }

        // DELETE api/
        [HttpDelete("{id}")]
        public async Task<ActionResult<Account>> Delete(int id)
        {
            Account user = db.Accounts.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            db.Accounts.Remove(user);
            await db.SaveChangesAsync();
            return Ok(user);
        }
    }
}
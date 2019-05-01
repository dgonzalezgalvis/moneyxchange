using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using MoneyXchange.Api.Models;

namespace MoneyXchange.Api.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ExchangesController : ApiController
    {
        private MoneyXchangeApiContext db = new MoneyXchangeApiContext();

        // GET: api/Exchanges
        public IQueryable<Exchange> GetExchanges()
        {
            return db.Exchanges;
        }

        // GET: api/Exchanges/5
        [ResponseType(typeof(Exchange))]
        public async Task<IHttpActionResult> GetExchange(int id)
        {
            Exchange exchange = await db.Exchanges.FindAsync(id);
            if (exchange == null)
            {
                return NotFound();
            }

            return Ok(exchange);
        }

        // GET: api/Exchanges
        [ResponseType(typeof(Exchange))]
        [Route("api/Exchanges/{from}/{to}")]
        public async Task<IHttpActionResult> GetExchangeBase([FromUri]string from, [FromUri]string to)
        {
            Exchange exchange = await db.Exchanges.FirstAsync(e => e.currency.Equals(to));
            if (exchange == null)
            {
                return NotFound();
            }

            return Ok(exchange);
        }

        // PUT: api/Exchanges/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutExchange(int id, Exchange exchange)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != exchange.Id)
            {
                return BadRequest();
            }

            db.Entry(exchange).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExchangeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Exchanges
        [ResponseType(typeof(Exchange))]
        public async Task<IHttpActionResult> PostExchange(Exchange exchange)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Exchanges.Add(exchange);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = exchange.Id }, exchange);
        }

        // DELETE: api/Exchanges/5
        [ResponseType(typeof(Exchange))]
        public async Task<IHttpActionResult> DeleteExchange(int id)
        {
            Exchange exchange = await db.Exchanges.FindAsync(id);
            if (exchange == null)
            {
                return NotFound();
            }

            db.Exchanges.Remove(exchange);
            await db.SaveChangesAsync();

            return Ok(exchange);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ExchangeExists(int id)
        {
            return db.Exchanges.Count(e => e.Id == id) > 0;
        }
    }
}
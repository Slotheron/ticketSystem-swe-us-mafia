﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketSystemEngine;
using TicketSystem.DatabaseRepository;
using Newtonsoft.Json;

namespace RESTapi.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class TicketController : Controller
    {
        TicketDatabase db = new TicketDatabase();
        // GET: api/Ticket
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: /ticket/5
        [HttpGet("{id}")]
        public Ticket Get(int id)
        {
            return db.FindTicketByTicketID(id);
        }
        
        // POST: /ticket
        [HttpPost("{id}")]
        public void CreateTicket(int id)
        {
            db.CreateTicket(id);
        }
        
        // PUT: /ticket/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: ticket/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (db.FindTicketByTicketID(id) == null)
            {
                Response.StatusCode = 404;
            }
            else
            {
                db.DeleteTicket(id);
            }
        }
    }
}

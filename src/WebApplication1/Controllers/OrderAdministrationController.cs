﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketSystem.DatabaseRepository;
using Newtonsoft.Json;
using TicketSystem.DatabaseRepository.Model;


namespace RESTapi.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class OrderAdministrationController : Controller
    {
        TicketDatabase ticketDB = new TicketDatabase();
 
        // GET: api/Ticket
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Ticket/5
        [HttpGet("/{query}")]
        public IEnumerable<Order> FindCustomerOrders(string query)
        {
            return ticketDB.FindCustomerOrders(query);
        }
        
        // POST: api/Ticket
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Ticket/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Order order)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
using Dummy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy.Controllers
{
    public class ExampleController : ApiController
    {
        private readonly ExampleContext db = new ExampleContext();
        [HttpPost]
        public IHttpActionResult SaveInfo(Example ex)
        {
            db.example.Add(ex);
            db.SaveChanges();
            return Ok(ex);
            //return Request.CreateErrorResponse(HttpStatusCode.OK, "Record Added Sucessfully");
        }
        [HttpGet]
        public List<Example> ShowInfo()
        {
            //var result = (from ex in db.example
            //              select new Example
            //              {
            //                  eid = ex.eid,
            //                  name = ex.name,
            //                  location = ex.location
            //              }).ToList<Example>();
            var result = db.example.Select(x => x).ToList<Example>();
            return result;

        }

        [HttpPut]
        public IHttpActionResult UpdateInfo(int id, Example exg)
        {
            db.Entry(exg).State = System.Data.Entity.EntityState.Modified;
            //try
            //{
            //    db.SaveChanges();
            //}
            //catch(DbUpdateConcurrencyException)
            //{
            //    return NotFound();
            //}
            //return Ok();
            db.SaveChanges();
            return Ok();
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //if (id != exg.eid)
            //{
            //    return BadRequest();
            //}

            //db.Entry(exg).State = EntityState.Modified;

            //try
            //{
            //    db.SaveChanges();
            //}
            //catch (DbUpdateConcurrencyException)
            //{

            //        throw;
            //}

            //return StatusCode(HttpStatusCode.NoContent);
        }

        [HttpDelete]
        public IHttpActionResult DeleteInfo(int id)
        {
            Example exampleinfo = db.example.Find(id);
            db.example.Remove(exampleinfo);
            db.SaveChanges();
            return Ok();
        }
    }
}

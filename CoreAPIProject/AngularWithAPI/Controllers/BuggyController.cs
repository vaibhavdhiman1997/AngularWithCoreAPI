using System;
using AngularWithAPI.Controllers;
using AngularWithAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    public class BuggyController : BaseAPIController
    {
        private readonly MyDBContext _context;
        public BuggyController(MyDBContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet("auth")]
        public ActionResult<string> GetSecret()
        {
            return "secret user";
        }

        [HttpGet("not-found")]
        public ActionResult<User> GetNotFound()
        {
            var thing = _context.Users.Find(-1);
            if (thing == null) return NotFound();
            return thing;
        }

        [HttpGet("server-error")]
        public ActionResult<string> GetServerError()
        {

            var thing = _context.Users.Find(-1);
            var thingToReturn = thing.ToString();
            return thingToReturn;

        }
        [HttpGet("bad-request")]
        public ActionResult<string> GetBadRequest()
        {
            return "This was not a good request";
        }
    }
}
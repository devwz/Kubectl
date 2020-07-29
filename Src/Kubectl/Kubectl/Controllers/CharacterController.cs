using Kubectl.Core.Data;
using Kubectl.Core.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kubectl.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : Controller
    {
        readonly CharacterDependency dependency;

        public CharacterController(CharacterDependency dependency)
        {
            this.dependency = dependency;
        }

        // GET api/character
        [HttpGet]
        public ActionResult<IEnumerable<Character>> Get()
        {
            return dependency.CreateCharacterCollection(16).ToList();
        }
    }
}

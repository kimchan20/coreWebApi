using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{

		[Route("display/getHelloWorld")]
		[HttpGet]
		public IActionResult getHelloWorld()
		{
			return StatusCode(200, "Hello World!");
		}
	}
}

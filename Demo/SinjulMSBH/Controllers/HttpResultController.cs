
using Demo.SinjulMSBH.Results;
using Microsoft.AspNetCore.Mvc;

namespace Demo.SinjulMSBH.Controllers
{
	[ApiController]
	[Route("api")]
	public class HttpResultController : Controller
	{
		[HttpGet, Route("Http200")]
		public ResponseResult Http200() =>
			new ResponseResult { ResultValue = "Hello World .. !!!!" };

		[HttpGet, Route("Http204")]
		public ResponseResult2 Http204()
		{
			//return null;
			return new ResponseResult2 { ResultValue = null, IsError = false };
		}

		[HttpGet, Route("HttpExplicitNoContent")]
		public IActionResult HttpExplicitNoContent() => new NoContentResult();
	}
}

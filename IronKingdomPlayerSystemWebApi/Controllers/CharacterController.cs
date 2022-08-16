using Microsoft.AspNetCore.Mvc;

namespace IronKingdomPlayerSystemWebApi.Controllers
{
	public class CharacterController : Controller
	{
		public IActionResult Index()
		{
			return Ok(new Character("Taco"));
		}
	}
}

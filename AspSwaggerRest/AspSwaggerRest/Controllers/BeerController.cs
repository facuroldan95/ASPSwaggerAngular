using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspSwaggerRest.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BeerController : ControllerBase
	{
		List<Beer> Beers = new List<Beer>()
		{
			new Beer(){ id=1, name="Budweiser"},
			new Beer(){ id=2, name="Corona"},
			new Beer(){ id=3, name="Quilmes"},
		};
		 [HttpGet]
		public ActionResult<Beer> Get(int id)
		{
			var beer = Beers.Where(d => d.id == id).FirstOrDefault();
			if (beer == null) return NotFound();
			return beer;
		}
		
	}

	public class Beer
	{
		public int id { get; set; }
		public string name { get; set; }
	}
}

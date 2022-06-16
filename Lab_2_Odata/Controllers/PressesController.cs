using Lab_2_Odata.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using System.Linq;

namespace Lab_2_Odata.Controllers
{

    public class PressesController : ODataController
    {

        private BookContext _context;

        public PressesController(BookContext context)
        {
            _context = context;
            if (context.Books.Count() == 0)
            {
                foreach (var item in DataSources.DataSource.GetBooks())
                {
                    context.Books.Add(item);
                    context.Presses.Add(item.Press);
                }
                context.SaveChanges();
            }
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_context.Presses);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Website_Assignment2.Models;
using Website_Assignment2.Services;

namespace Website_Assignment2.Pages
{
	public class CarListModel : PageModel
    {

        public JsonFileCarService CarService;

        public IEnumerable<Car> Cars { get; private set; } = default!;

        public CarListModel(ILogger<IndexModel> logger, JsonFileCarService carService)
        {
            
            CarService = carService;
        }

        public void OnGet()
        {
           
            Cars = CarService.GetProducts();
        }

    }

    
}



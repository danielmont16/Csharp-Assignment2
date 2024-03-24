using System;
using System.Text.Json;
using Website_Assignment2.Models;


namespace Website_Assignment2.Services
{
	public class JsonFileCarService
	{
		public JsonFileCarService(IWebHostEnvironment webHostEnvironment)
		{
			WebHostEnvironment = webHostEnvironment;

        }

        public IWebHostEnvironment WebHostEnvironment { get; }


        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "Cars.json");



        public IEnumerable<Car> GetProducts()
        {
            using var jsonFileReader = File.OpenText(JsonFileName);


             return JsonSerializer.Deserialize<Car[]>
                (jsonFileReader.ReadToEnd(),
                 new JsonSerializerOptions
                 {
                     PropertyNameCaseInsensitive = true
                 })!;
        }



    }//end JsonFileCarService class

}


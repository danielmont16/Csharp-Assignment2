using System;
using System.Text.Json;

namespace Website_Assignment2.Models
{
	public class Car
	{
		public int? Id { get; set; }
        public string? Model { get; set; }
        public string? Company { get; set; }
        public int? Year { get; set; }
        public string? Image { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Car>(this);

    }
}


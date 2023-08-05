using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Models
{
	public class Menu : IMenu
	{
		public Menu(string name, string description, string color)
		{
			Name = name;
			Description = description;
			Color = color;
		}

		public string Name { get; set; }
		public string Description { get; set; }
		public string Color { get; set; }



	}
}

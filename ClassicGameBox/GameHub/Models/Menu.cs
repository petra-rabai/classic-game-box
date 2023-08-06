using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Models
{
	public class Menu : IMenu
	{
		
		public string Name { get; set; }
		public string Description { get; set; }
		public ConsoleColor Color { get; set; }
		public char Key { get; set; }



	}
}

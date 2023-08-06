using GameHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.UI
{
	public class UIElementHandler
	{
		public List<Menu> InitializeMenuList()
		{
			List<Menu> list = new()
			{
				new Menu()
				{
					Name = "New game",
					Description = "Start a new game",
					Color = ConsoleColor.White,
					Key = 'N'
				},
				new Menu()
				{
					Name = "Save game",
					Description = "Save the current game",
					Color = ConsoleColor.Yellow,
					Key = 'S'
				},
				new Menu()
				{
					Name = "Load game",
					Description = "Load the current game",
					Color = ConsoleColor.Blue,
					Key = 'L'
				},
				new Menu()
				{
					Name = "Settings",
					Description = "Game option settings",
					Color = ConsoleColor.Green,
					Key = 'O'
				},
				new Menu()
				{
					Name = "Exit",
					Description = "Exit from the Game",
					Color = ConsoleColor.Red,
					Key = 'E'
				}
			};

			return list;
		}
	}
}

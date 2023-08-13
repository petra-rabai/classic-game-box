using GameHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.UI
{
	public class MainScreen
	{
		

		public void Initialize()
		{
			Setup setupApplication = new Setup();
			setupApplication.SetConsoleWindow();
			UIElementHandler uIElementHandler = new UIElementHandler();
			List<Menu> menu = uIElementHandler.InitializeMenuList();
            foreach (Menu menuItem in menu)
            {
				Console.ForegroundColor = menuItem.Color;
				setupApplication.SetConsoleCursor();
				Console.WriteLine($"Key:{menuItem.Key} -- {menuItem.Name}\nDescription: {menuItem.Description}\n ");
            }
            
		}
		
	}
}

namespace GameHub.Models
{
	public interface IMenu
	{
		ConsoleColor Color { get; set; }
		string Description { get; set; }
		string Name { get; set; }
		char Key { get; set; }
	}
}
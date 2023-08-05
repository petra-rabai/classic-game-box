namespace GameHub.Models
{
	public interface IUser
	{
		string Email { get; set; }
		int Id { get; set; }
		string Password { get; set; }
		string Username { get; set; }
	}
}
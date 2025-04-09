namespace Domain.DTOs.Users;

public class CreateUserDto
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Bio { get; set; }
    public DateTime JoinDate { get; set; }
}
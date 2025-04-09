namespace Domain.DTOs;

public class NewRegistrationDto
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public DateTimeOffset JoinDate { get; set; }
}
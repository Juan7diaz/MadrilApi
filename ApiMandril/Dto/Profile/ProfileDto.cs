namespace ApiMandril.Dto.Profile;

public class ProfileDto
{
    public Guid Id { get; set; }
    public string Biography { get; set; }
    public string ImageUrl { get; set; }
    public Guid UserId { get; set; }
}
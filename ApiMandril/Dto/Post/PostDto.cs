namespace ApiMandril.Dto.Post;

public class PostDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime DateCreated { get; set; }
    public Guid UserId { get; set; }
    public string UserName { get; set; }
}
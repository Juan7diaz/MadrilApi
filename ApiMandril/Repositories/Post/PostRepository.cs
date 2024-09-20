namespace ApiMandril.Repositories.Post;
using Data;
using Microsoft.EntityFrameworkCore;
using Models;

public class PostRepository : IPostRepository
{
    
    private readonly ApplicationDbContext _context;

    public PostRepository(ApplicationDbContext context)
    {
        this._context = context;
    }
    
    public async Task<IEnumerable<Post>> GetAllPostsAsync()
    {
        return await _context.Posts.ToListAsync();
    }

    public async Task<Post> GetPostByIdAsync(Guid id)
    {
        return await _context.Posts.FindAsync(id);
    }
    
    public async Task AddPostAsync(Post post)
    {
        await _context.Posts.AddAsync(post);
        await _context.SaveChangesAsync();
    }

    public async Task UpdatePostAsync(Post post)
    {
        _context.Posts.Update(post);
        await _context.SaveChangesAsync();
    }

    public async Task DeletePostAsync(Guid id)
    {
        var post = await _context.Posts.FindAsync(id);
        if (post != null)
        {
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
        }
    }
}
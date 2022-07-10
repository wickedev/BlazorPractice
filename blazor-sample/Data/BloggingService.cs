using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace blazor_sample.Data;

public class BloggingService
{
    private readonly BloggingContext db;

    public BloggingService(BloggingContext context)
    {
        this.db = context;
    }

    public List<Post> GetPosts() => db.Posts.ToList();

    public Post Posting(Post post)
    {
        Console.WriteLine("post",post);
       return db.Posts.Add(post).Entity;
    }

    public int Delete(int id)
    {
        var post = new Post() { Id = id };
        db.Posts.Attach(post);
        db.Posts.Remove(post);
        return db.SaveChanges();
    }
}


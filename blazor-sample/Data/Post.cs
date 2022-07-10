using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blazor_sample.Data;

public class Post
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Int64 Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public override string ToString()
    {
        return $"{{Id: {Id}, Title: {Title}, Content: {Content} }}"; 
    }
}

using BlogPostAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPostAPI.Data
{
    public class PostDbContext : DbContext
    {

        public PostDbContext(DbContextOptions<PostDbContext>options):base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
    }
}

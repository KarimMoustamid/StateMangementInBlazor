namespace StateManagement.Shared.Repositories
{
    using Interface;
    using Model;

    public class BlogRepository : IBlogRepository
    {
        List<BlogPost> blogPosts = new()
        {
            new BlogPost {Id = 1, Title = "Blog Post 1", Content = "Content of Blog Post 1"},
            new BlogPost {Id = 2, Title = "Blog Post 2", Content = "Content of Blog Post 2"},
            new BlogPost {Id = 3, Title = "Blog Post 3", Content = "Content of Blog Post 3"}
        };

        public Task<List<BlogPost>> GetPosts() => Task.FromResult(blogPosts);

        public Task<BlogPost> getPost(int id) => Task.FromResult(blogPosts.FirstOrDefault(p => p.Id == id));

        public Task AddPost(string title, string content)
        {
            var newId = blogPosts.Count() != 0 ? blogPosts.Max(post => post.Id) + 1 : 0;
            var newPost = new BlogPost {Id = newId, Title = $"New post {newId}", Content = "This is a new blog post"};
            return Task.Run(() => blogPosts.Add(newPost));
        }

        public Task UpdatePost(BlogPost post)
        {
            throw new NotImplementedException();
        }

        public Task DeletePost(int id)
        {
            throw new NotImplementedException();
        }

    }
}
namespace StateManagement.Shared.Interface
{
    using Model;

    public interface IBlogRepository
    {
        Task<List<BlogPost>> GetPosts();

        Task<BlogPost> getPost(int id);

        Task AddPost(string title, string content);

        Task UpdatePost(BlogPost post);

        Task DeletePost(int id);

    }
}
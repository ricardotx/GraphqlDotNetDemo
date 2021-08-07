using GraphqlDotNetDemo.Src.Data.Models;

namespace GraphQLDotNet.Src.Data.Repositories
{
    public interface IRoleRepository : IBaseRepository<Role>
    {
        // We only need a method that already exists in the BaseRepository
    }
}

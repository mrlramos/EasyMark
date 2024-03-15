using EasyMark.Domain.Entities;
using EasyMark.Domain.Interfaces;
using EasyMark.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace EasyMark.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<User> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return await Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
        }
    }
}
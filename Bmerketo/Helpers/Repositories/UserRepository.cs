using Bmerketo.Contexts;
using Bmerketo.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Bmerketo.Helpers.Repositories
{
    public class UserRepository : Repo<UserEntity>
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<UserEntity> UpdateAsync(UserEntity entity)
        {
            try
            {
                _context.Set<UserEntity>().Update(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return null!;
        }
    }
}

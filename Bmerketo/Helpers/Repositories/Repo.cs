using Bmerketo.Contexts;
using Bmerketo.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Bmerketo.Helpers.Repositories;

public abstract class Repo<TEntity> where TEntity : class
{
    private readonly DataContext _context;

    protected Repo(DataContext context)
    {
        _context = context;
    }

    public virtual async Task<TEntity> AddAsync(TEntity entity)
    {
        try
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

    public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
    {
        try
        {
            var entity = await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);
            if (entity != null)
            {
                return entity;
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message) ;  }
        return null!;
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        try
        {
            var entities = await _context.Set<TEntity>().ToListAsync();
            if (entities != null)
            {
                return entities;
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

    public virtual async Task<TEntity> UpdateAsync(TEntity entity)
    {
        try
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }
}

using Bmerketo.Contexts;
using Bmerketo.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bmerketo.Helpers.Repositories;

public class ContactFormRepository : Repo<ContactFormEntity>
{
    private readonly DataContext _context;
    public ContactFormRepository(DataContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<ContactFormEntity>> GetAllAsync()
    {
        var messages = await _context.ContactForms.ToListAsync();
        return messages;
    }
}

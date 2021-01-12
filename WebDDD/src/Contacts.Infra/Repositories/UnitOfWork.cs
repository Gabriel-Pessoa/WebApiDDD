using System.Threading.Tasks;
using Contacts.Domain.Interfaces;
using Contacts.Infra.Context;

namespace Contacts.Infra.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
        
    }
}
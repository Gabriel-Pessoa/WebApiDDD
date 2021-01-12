using System.Collections.Generic;
using System.Linq;
using Contacts.Domain.Models;
using Contacts.Infra.Context;

namespace Contacts.Infra.Repositories
{
    public class ContactRepository : Repository<Contact>
    {
        public ContactRepository(AppDbContext context) : base(context)
        {}

        public override Contact GetById(int id)
        {
            var query = _context.Set<Contact>().Where(e => e.Id == id);
            
            if(query.Any())
            {
                return query.First();
            }

            return null;
        }

         public override IEnumerable<Contact> GetAll()
        {
            var query = _context.Set<Contact>();

            return query.Any() ? query.ToList() : new List<Contact>();
        }
                
    }
}
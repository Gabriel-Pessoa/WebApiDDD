using System.Threading.Tasks;

namespace Contacts.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
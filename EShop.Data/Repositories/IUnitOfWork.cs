using System;

namespace EShop.Data.Repositories
{
    public interface IUnitOfWork:IDisposable
    {
        IUserRepository UserRepository { get; }
        int Complete();
    }
}

namespace EShop.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EShopDbContext _context;
        public UnitOfWork(EShopDbContext context)
        {
            _context = context;
            UserRepository = new UserRepository(_context);
        }
        public IUserRepository UserRepository { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

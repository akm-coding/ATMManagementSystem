using ATMManagement.MvcApp.Models;

namespace ATMManagement.MvcApp.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public int SaveUser(UserModel userModel)
        {
            _context.User.Add(userModel);
            return _context.SaveChanges();
        }
    }
}

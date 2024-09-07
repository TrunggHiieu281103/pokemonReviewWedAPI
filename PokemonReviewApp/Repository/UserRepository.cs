using PokemonReviewApp.Data;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public User UserLogin(User user)
        {
            return _context.Users.FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);
        }

        public ICollection<User> GetUsers()
        {
            return _context.Users.OrderBy(u => u.Id).ToList();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool UserExists(int userId)
        {
            return _context.Users.Where(x => x.Id == userId).Any();
        }

        public User GetUser(string username, string password)
        {
            return _context.Users.FirstOrDefault(x => x.Username == username && x.Password == password);

        }

        public User GetUser(int userId)
        {
            return _context.Users.FirstOrDefault(x => x.Id == userId);

        }
    }
}

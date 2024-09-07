using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();
        User UserLogin(User user);
        User GetUser(string username, string password);
        User GetUser(int userId);
        bool UserExists(int userId);
        bool CreateUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(User user);
        bool Save();
    }
}

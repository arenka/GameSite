using GameSite.Data.Entity;

namespace GameSite.Service.Services
{
    public interface IUserService
    {
        User GetByUsernameAndPassword(string userName, string password);
        void Insert(User user);
        User GetById(int parse);
        void Update(User lastUser);
        void Delete(User deletedUser);
    }
}

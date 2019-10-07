using GameSite.Data.Entity;
using GameSite.Data.Repositories;

namespace GameSite.Service.Services.Impl
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;

        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }

        public User GetByUsernameAndPassword(string userName, string password)
        {
            return _repository.GetBy(_ => _.UserName == userName && _.Password.ToString() == password);
        }

        public void Insert(User user)
        {
            _repository.Insert(user);
        }

        public User GetById(int parse)
        {
            return _repository.GetBy(_ => _.Id == parse);
;        }

        public void Update(User lastUser)
        {
            _repository.Update(lastUser);
        }

        public void Delete(User deletedUser)
        {
            _repository.Delete(deletedUser);
        }
    }
}

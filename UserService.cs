using Banking_Management_System.DTOS;
using Banking_Management_System.Models;
using Banking_Management_System.Repositorys;

namespace Banking_Management_System.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _rep;

        public UserService(IUserRepository rep)
        {
            _rep = rep;
        }

        public User GetuserByname(string name)
        {
           return _rep.GetuserByname(name);
        }

        public User Login(LoginDto dto)
        {
            return _rep.Login(dto);
        }

        public User Register(RegisterDto dto)
        {
            return _rep.Register(dto);
        }
    }
}

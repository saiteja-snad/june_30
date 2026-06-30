using Banking_Management_System.DTOS;
using Banking_Management_System.Models;

namespace Banking_Management_System.Repositorys
{
    public interface IUserRepository
    {
        User Register(RegisterDto dto);
        User Login(LoginDto dto);
       User GetuserByname(string name);
    }
}

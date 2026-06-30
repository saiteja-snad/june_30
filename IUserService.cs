using Banking_Management_System.DTOS;
using Banking_Management_System.Models;

namespace Banking_Management_System.Services
{
    public interface IUserService
    {
        User Register(RegisterDto dto);
        User Login(LoginDto dto);
        User GetuserByname(string name);
    }
}

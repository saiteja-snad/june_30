using Banking_Management_System.Data;
using Banking_Management_System.DTOS;
using Banking_Management_System.Exceptions;
using Banking_Management_System.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Banking_Management_System.Repositorys
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public User GetuserByname(string name)
        {
            var r = _context.users.FirstOrDefault(e => e.UserName == name);
            if (r == null)
            {
                throw new  UserNotFoundException("user not found");
            }
     
                return r;
            
        }

        public User Login(LoginDto dto)
        {
            var u = _context.users.FirstOrDefault(u => u.UserName == dto.username);
            if(u == null)
            {
                throw new UserNotFoundException("user not found");
            }
            if (u.Password != dto.password)
            {
                throw new UserNotFoundException("user not found");
            }
            return u;
        }

        public User Register(RegisterDto dto)
        {
           User u=new User();
            u.UserName=dto.userName;
            u.Password=dto.password;
            u.Role=dto.Role; 
            _context.users.Add(u);
            _context.SaveChanges();
            return u;
        }
    }
}

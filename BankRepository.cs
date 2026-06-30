using Banking_Management_System.Controllers;
using Banking_Management_System.Data;
using Banking_Management_System.DTOS;
using Banking_Management_System.Exceptions;
using Banking_Management_System.Models;

namespace Banking_Management_System.Repositorys
{
    public class BankRepository : IBankRepository
    {
        private readonly ApplicationDbContext _context;

        public BankRepository(ApplicationDbContext context)
        {
            _context= context;
        }

        public Bank AddBank(AddBankDto dto)
        {
            Bank ban = new Bank();
            ban.CoustomerName = dto.CoustomerName;
            ban.Email=dto.Email;
            ban.Phone = dto.Phone;
            ban.Address = dto.Address;
            ban.AccountType = dto.AccountType;
            ban.Balance = dto.Balance;  
            ban.Branch = dto.Branch;
            ban.IfscCode = dto.IfscCode;
            ban.AccountStatus = dto.AccountStatus;
            ban.CreatedDate = DateTime.UtcNow; ;
            _context.banks.Add(ban);
            _context .SaveChanges();
            return ban;
        }

        public bool deletebank(int id)
        {
            var bank = _context.banks.Find(id);
            if (bank == null)
            {
                return false;
            }
            _context.banks.Remove(bank);
            _context.SaveChanges(); 
            return true;
        }

        public List<Bank> GetAll()
        {
           return _context .banks.ToList();
        }

        public Bank GetById(int id)
        {
            var r=_context.banks.Find(id);
           
                if (r == null)
                {
                    throw new AcountNotFoundException("account not found");
                }
            return r;
        }

        public List<Bank> GetPages(int pageno, int pagesize)
        {
            return _context.banks.Skip((pageno - 1) * (pagesize)).Take(pagesize).ToList();
        }

        public List<Bank> searchAccountType(string accountType)
        {
            var b=_context.banks.Where(e => e.AccountType==accountType).ToList();
            
            return b;


        }

        public List <Bank> searchBranch(string branch)
        {
            var b = _context.banks.Where(e => e.Branch==branch).ToList();
           
            return b;
        }

        public List <Bank>searchbybalance(int balance)
        {
            var b = _context.banks.Where(e => e.Balance==balance).ToList();
            
            return b;
        }

        public List<Bank> searchbystatus(string status)
        {
            var b = _context.banks.Where(e => e.AccountStatus==status).ToList();
           
            
            return b;
        }

        public List<Bank>searchname(string name)
        {
            var b = _context.banks.Where(e => e.CoustomerName==name).ToList();
            
            return b;
        }

        public List<Bank> sortbalance()
        {
           return _context.banks.OrderBy(e=>e.Balance).ToList();
        }

        public List<Bank> sortBranch()
        {
            return _context.banks.OrderBy(e => e.Branch).ToList();
        }

        public List<Bank>sortName()
        {
            return _context.banks.OrderBy(e => e.CoustomerName).ToList();
        }

        public Bank Updatebank(int id,UpdateBankDto dto)
        {
            var ban= _context.banks.Find(id);
            if (ban == null)
            {
                throw new AcountNotFoundException("account not found");
            }
            else { 
                ban.CoustomerName = dto.CoustomerName;
                ban.Branch = dto.Branch;
                ban.Address = dto.Address;
                ban.Phone = dto.Phone;
                ban.Balance = dto.Balance;
                ban.IfscCode = dto.IfscCode;
                ban.AccountStatus = dto.AccountStatus;
                ban.Email = dto.Email;
            }
                _context.SaveChanges();
                return ban;
            
        }

        
    }
}

using Banking_Management_System.Controllers;
using Banking_Management_System.DTOS;
using Banking_Management_System.Models;
using Banking_Management_System.Repositorys;

namespace Banking_Management_System.Services
{
    public class BankService : IBankService
    {
        private readonly IBankRepository _rep;
        public BankService(IBankRepository rep)
        {
            _rep= rep;
        }
        public Bank AddBank(AddBankDto dto)
        {
            return _rep.AddBank(dto);
        }

        public bool deletebank(int id)
        {
            return  _rep.deletebank(id);
        }

        public List<Bank> GetAll()
        {
            return _rep.GetAll();
        }

        public Bank GetById(int id)
        {
            return _rep.GetById(id);
        }

        public List<Bank> GetPages(int pageno, int pagesize)
        {
           return _rep.GetPages(pageno, pagesize);
        }

        public List<Bank> searchAccountType(string accountType)
        {
           return _rep.searchAccountType(accountType);
        }

        public List<Bank> searchBranch(string branch)
        {
           return _rep.searchBranch(branch);
        }

        public List<Bank> searchbybalance(int balance)
        {
          return _rep.searchbybalance(balance);
        }

        public List<Bank> searchbystatus(string status)
        {
            return _rep.searchbystatus(status);
        }

        public List<Bank> searchname(string name)
        {
           return (_rep.searchname(name));
        }

        public List<Bank> sortbalance()
        {
            return _rep.sortbalance();
        }

        public List<Bank> sortBranch()
        {
            return _rep.sortBranch();
        }

        public List<Bank> sortName()
        {
           return _rep.sortName();
        }

        public Bank Updatebank(int id, UpdateBankDto dto)
        {
           return _rep.Updatebank(id, dto);
        }
    }
}

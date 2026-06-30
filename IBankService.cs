using Banking_Management_System.Controllers;
using Banking_Management_System.DTOS;
using Banking_Management_System.Models;

namespace Banking_Management_System.Services
{
    public interface IBankService
    {
        List<Bank> GetAll();
        Bank GetById(int id);

        Bank AddBank(AddBankDto dto);
        Bank Updatebank(int id, UpdateBankDto dto);

        bool deletebank(int id);

        List<Bank> searchname(string name);
        List<Bank> searchBranch(string branch);
        List<Bank> searchAccountType(string accountType);

        List<Bank> searchbybalance(int balance);

        List<Bank> searchbystatus(string status);

        List<Bank> sortbalance();
        List<Bank> sortName();

        List<Bank> sortBranch();
        List<Bank> GetPages(int pageno, int pagesize);
    }
}

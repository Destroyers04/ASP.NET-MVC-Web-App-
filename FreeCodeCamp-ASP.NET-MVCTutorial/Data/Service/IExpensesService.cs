using FreeCodeCamp_ASP.NET_MVCTutorial.Models;

namespace FreeCodeCamp_ASP.NET_MVCTutorial.Data.Service
{
    public interface IExpensesService
    {
        Task<IEnumerable<Expense>> GetAll();
        Task Add(Expense expense);
    }
}

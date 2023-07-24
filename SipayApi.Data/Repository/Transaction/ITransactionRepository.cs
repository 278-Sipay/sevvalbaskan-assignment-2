using sevvalbaskan_assignment_2.Data.Repository;
using System.Linq.Expressions;
using System.Transactions;

namespace sevvalbaskan_assignment_2.Data.Repository;

public interface ITransactionRepository : IGenericRepository<Transaction>
{
    List<Transaction> GetByReference(string reference);

    
    List<Transaction> GetByParameter(Expression<Func<Transaction, bool>> filterExpression);
	object GetByParameter(int accountNumber, decimal? minCreditAmount, decimal? maxCreditAmount, decimal? minDebitAmount, decimal? maxDebitAmount, string description, DateTime? beginDate, DateTime? endDate, string referenceNumber);
}

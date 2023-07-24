
using sevvalbaskan_assignment_2.Data.Repository;
using sevvalbaskan_assignment_2.Data;
using System.Linq.Expressions;
using sevvalbaskan_assignment_2.Data.Domain;

namespace sevvalbaskan_assignment_2.Data.Repository;

public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
{
	private readonly SimDbContext dbContext;
	public TransactionRepository(SimDbContext dbContext) : base(dbContext)
	{
		this.dbContext = dbContext;
	}

	public List<Transaction> GetByReference(string reference)
	{
		return dbContext.Set<Transaction>().Where(x => x.ReferenceNumber == reference).ToList();
	}

	//GetBy parameter method
	public List<Transaction> GetByParameter(Expression<Func<Transaction, bool>> filterExpression)
	{
		return dbContext.Set<Transaction>().Where(filterExpression).ToList();
	}

	List<System.Transactions.Transaction> ITransactionRepository.GetByReference(string reference)
	{
		throw new NotImplementedException();
	}

	public List<System.Transactions.Transaction> GetByParameter(Expression<Func<System.Transactions.Transaction, bool>> filterExpression)
	{
		throw new NotImplementedException();
	}

	System.Transactions.Transaction IGenericRepository<System.Transactions.Transaction>.GetById(int id)
	{
		throw new NotImplementedException();
	}

	public void Insert(System.Transactions.Transaction entity)
	{
		throw new NotImplementedException();
	}

	public void Update(System.Transactions.Transaction entity)
	{
		throw new NotImplementedException();
	}

	public void Delete(System.Transactions.Transaction entity)
	{
		throw new NotImplementedException();
	}

	List<System.Transactions.Transaction> IGenericRepository<System.Transactions.Transaction>.GetAll()
	{
		throw new NotImplementedException();
	}

	IQueryable<System.Transactions.Transaction> IGenericRepository<System.Transactions.Transaction>.GetAllAsQueryable()
	{
		throw new NotImplementedException();
	}

	public object GetByParameter(int accountNumber, decimal? minCreditAmount, decimal? maxCreditAmount, decimal? minDebitAmount, decimal? maxDebitAmount, string description, DateTime? beginDate, DateTime? endDate, string referenceNumber)
	{
		throw new NotImplementedException();
	}
}

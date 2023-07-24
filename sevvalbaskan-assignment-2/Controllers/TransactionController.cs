using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using sevvalbaskan_assignment_2.Base;
using sevvalbaskan_assignment_2.Data.Repository;
using sevvalbaskan_assignment_2.Schema;
using sevvalbaskan_assignment_2.SipayApi.Schema;
using System.Linq.Expressions;
using System.Transactions;

namespace sevvalbaskan_assignment_2;

[ApiController]
[Route("sipay/api/[controller]")]
public class TransactionController : ControllerBase
{
	private readonly ITransactionRepository repository;
	public TransactionController(ITransactionRepository repository)
	{
		this.repository = repository;
	}

	[HttpGet("GetByParameters")]
	public ApiResponse<List<Transaction>> GetByParameters(int accountNumber, decimal? minCreditAmount, decimal? maxCreditAmount,
															 decimal? minDebitAmount, decimal? maxDebitAmount, string description,
															 DateTime? beginDate, DateTime? endDate, string referenceNumber)
	{
		var List = repository.GetByParameter(accountNumber, minCreditAmount, maxCreditAmount, minDebitAmount, maxDebitAmount, description, beginDate, endDate, referenceNumber);


		return new ApiResponse<List<Transaction>>(List);
	}
}
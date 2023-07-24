using AutoMapper;
using sevvalbaskan_assignment_2.Data.Domain;
using sevvalbaskan_assignment_2.SipayApi.Schema;

namespace sevvalbaskan_assignment_2.Schema;

public class MapperConfig : Profile
{
	public MapperConfig()
	{

		CreateMap<TransactionRequest, Transaction>();
		CreateMap<Transaction, TransactionResponse>();
	}
}

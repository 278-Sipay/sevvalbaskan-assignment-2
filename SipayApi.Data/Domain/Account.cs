﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sevvalbaskan_assignment_2.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace sevvalbaskan_assignment_2.Data.Domain;

[Table("Account", Schema = "dbo")]
public class Account : BaseModel
{
	//Primary key 
	//tablo oluşturma
	public int AccountNumber { get; set; }


	public int CustomerNumber { get; set; }
	public virtual Customer Customer { get; set; }

	public decimal Balance { get; set; }
	public string Name { get; set; }
	public DateTime OpenDate { get; set; }
	public string CurrencyCode { get; set; }
	public bool IsActive { get; set; }


	public virtual List<Transaction> Transactions { get; set; }
}



public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
	public void Configure(EntityTypeBuilder<Account> builder)
	{
		builder.Property(x => x.AccountNumber).IsRequired(true).ValueGeneratedNever();
		builder.HasIndex(x => x.AccountNumber).IsUnique(true);
		builder.HasKey(x => x.AccountNumber);


		builder.Property(x => x.InsertUser).IsRequired(true).HasMaxLength(50);
		builder.Property(x => x.InsertDate).IsRequired(true);

		builder.Property(x => x.CurrencyCode).IsRequired(true).HasMaxLength(4);
		builder.Property(x => x.Balance).IsRequired(true).HasPrecision(15, 4).HasDefaultValue(0);
		builder.Property(x => x.CustomerNumber).IsRequired(true);
		builder.Property(x => x.IsActive).IsRequired(true).HasDefaultValue(true);
		builder.Property(x => x.Name).IsRequired(true).HasMaxLength(100);
		builder.Property(x => x.OpenDate).IsRequired(true);

		builder.HasIndex(x => x.CustomerNumber);

		builder.HasMany(x => x.Transactions)
			.WithOne(x => x.Account)
			.HasForeignKey(x => x.AccountNumber)
			.IsRequired(true);
	}

}
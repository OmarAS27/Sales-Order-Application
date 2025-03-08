using System;

public class Check:Payment
{
	public String name { get; set; }
	public double value { get; set; }

	public String BankId { get; set; }
	public Check(string name, double value, string bankId) : base(value)
	{
		this.name = name;
		this.BankId = bankId;
	}
}

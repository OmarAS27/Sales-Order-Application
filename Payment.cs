using System;

public class Payment
{
	public DateTime paid_date;

	public double amount { get; set; }	
	public Payment( double amount)
	{
		this.paid_date = DateTime.Now;
		this.amount = amount;
	}


}

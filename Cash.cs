using System;

public class Cash:Payment
{
	public double CashValue { get; set; }
	public Cash(double cashValue):base(cashValue)
	{
		
	}
}

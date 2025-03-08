using System;

public class Transaction
{
	public int Customer_ID { get; set; }
	public DateTime Transaction_Time { get; set; }
    public  static List<Order> orders = new List<Order>();
	
	public static List<Payment> payments = new List<Payment>();

	public static List<Transaction> transactions = new List<Transaction>();
	public Transaction(int customerId)
	{
		this.Customer_ID = customerId;
		this.Transaction_Time=DateTime.Now;
	}

	public static void GetOrder(Order order)
	{
		orders.Add(order);
		
	}
    public static Transaction Transaction_Search(int cust_Id)
    {
        var transaction = transactions.Find(i => i.Customer_ID == cust_Id);
        if (transaction != null)
        {
            return transaction;
        }
        else
        {
            Console.WriteLine("Not Found");
            return null;
        }
    }
    public static Order Search_Order(int customerId)
	{
        var order = orders.Find(i => i.Customer_Id == customerId);
        if (order != null)
        {
            return order;
        }
        else
        {
            Console.WriteLine("Not Found");
            return null;
        }
    }

    public static void AddPayment(Payment payment,Order order)
    {
        payments.Add(payment);
		if (payment.amount >= order.Order_price)
		{
			order.UpdateOrderStatus(3);
		}
		else if(payment.amount <= order.Order_price)
		{
			order.UpdateOrderStatus(2);
		}
    }

	public static void print()
	{
		foreach(var transaction in transactions)
		{
			foreach (var order in orders)
			{
				foreach (var payment in payments)
				{


					Console.WriteLine("\nTransaction_Customer_Id: " + transaction.Customer_ID
						+ "\nTransaction_Date:" + transaction.Transaction_Time +
						"Order_Number" + order.Order_Number
						+ "Order_Status" + order.orderStatus
						+ "Order_Price" + order.Order_price
						+"Paid"+ payment.amount

						);
				}
			}
		}
	}
}

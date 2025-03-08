using System;

public class Order
{
	public int Customer_Id { get; set; }
	public int Order_Number { get; set; }

	public DateTime Order_time { get; set; }
	public double Order_price { get; set; }
    public OrderStatus orderStatus { get; set; }
    public  enum OrderStatus
    {
        New,
        Hold,
        Paid,
        Cancelled
    }
    public List<OrderItem> orderItems= new List<OrderItem>();
    public Order(int Customer_Id , int orderStatus )
	{
        Random rng = new Random();

        this.Customer_Id = Customer_Id;
        this.Order_time = DateTime.Now;
        this.orderStatus =(OrderStatus)orderStatus;
        this.Order_Number = rng.Next(1, 100001);
    }

    public void Add_OrderItem(OrderItem orderItem)
    {
        this.orderItems.Add(orderItem);
        this.Order_price += orderItem.Order_Item_Sale_Price;
    }
    public void UpdateOrderStatus(int orderStatus_new)
    {
        this.orderStatus = (OrderStatus)orderStatus_new;
    }

}

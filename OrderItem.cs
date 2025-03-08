using System;

public class OrderItem
{
	public double Order_Item_Sale_Price { get; set; }
	public int Order_Product_Quantity { get; set; }

	public Product Product { set; get; }

	public OrderItem( int order_Product_Quantity, Product product)
	{
		this.Order_Item_Sale_Price =product.Product_Price*this.Order_Product_Quantity ;
		this.Order_Product_Quantity = order_Product_Quantity;
		this.Product = product;
	}

	public void Update_Quantity(int New_Quantity)
	{
		if(New_Quantity>this.Product.Product_Quantity)
		{
			Console.WriteLine("There isn't enought quantity of the product we have only: "+ this.Product.Product_Quantity);
		}
		else if (New_Quantity<=this.Product.Product_Price && New_Quantity>=0)
		{
			this.Order_Product_Quantity = New_Quantity;
			this.Order_Item_Sale_Price = this.Product.Product_Price * New_Quantity;
		}

	}

    public static OrderItem operator ++(OrderItem item)
    {
        if (item.Order_Product_Quantity < item.Product.Product_Quantity)
        {
            item.Order_Product_Quantity++;
        }
        return item;
    }
    public static OrderItem operator --(OrderItem item)
    {
        if (item.Order_Product_Quantity > 0)
        {
            item.Order_Product_Quantity--;
        }
        return item;
    }
    public static OrderItem operator +(OrderItem item, int n)
    {
        if ((item.Order_Product_Quantity + n) <= item.Product.Product_Quantity)
        {
            item.Order_Product_Quantity += n;
        }
        return item;
    }
    public static OrderItem operator -(OrderItem item, int n)
    {
        if ((item.Order_Product_Quantity - n) >= 0)
        {
            item.Order_Product_Quantity -= n;
        }
        return item;
    }
}

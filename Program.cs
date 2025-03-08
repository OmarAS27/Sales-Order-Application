namespace Sales_Order_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customers.create();
            Product.create();
            Customers.assign();
            Product.assign();
            Customer customer= new Customer(true,"test","test",0,"test");
            Order order=new Order(0,1);
            Transaction transaction= new Transaction(0);
            bool running = true;
            int Process;
            int Data_Entry_Choice;
            int Sales_Choice;
            int Print_Choice;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Sales Order Application");
                Console.WriteLine("1: Data Entry");
                Console.WriteLine("2: Sales Process");
                Console.WriteLine("3: Print");
                Console.WriteLine("4: Close The Program");
                Console.WriteLine("Choose the number of the operation you want to do");

                Process = Convert.ToInt32(Console.ReadLine());

                switch(Process)
                {


                    case 1:
                        Console.Clear();
                        Console.WriteLine("Welcome to the Data Entry");
                        Console.WriteLine("1. Add New/Update/Delete Customer");
                        Console.WriteLine("2. Add New/Update/Delete Product in Stock");
                        Console.WriteLine("Choose the number of the operation you want to do");
                        Data_Entry_Choice = Convert.ToInt32(Console.ReadLine());
                        if(Data_Entry_Choice==1)
                        {
                            DataEntry_Customer();
                        }
                        else if(Data_Entry_Choice==2)
                        {
                            DataEntry_Stock();
                        }
                        else
                        {
                            Console.WriteLine("Choose from the options");
                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Welcome to the Sales Process");
                        Console.WriteLine("1. Add Transaction");
                        Console.WriteLine("2. Update Order");
                        Console.WriteLine("3. Pay Order");
                        Console.WriteLine("Choose the number of the operation you want to do");
                        Sales_Choice = Convert.ToInt32(Console.ReadLine());
                        Sales_Process(Sales_Choice, running, customer, transaction,order);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Welcome to Print");
                        Console.WriteLine("1. Customers");
                        Console.WriteLine("2. Stock data");
                        Console.WriteLine("3. Transactions");
                        Console.WriteLine("Choose the number of the operation you want to do");
                        Print_Choice = Convert.ToInt32(Console.ReadLine());
                        if (Print_Choice == 1)
                        {
                            Customers.print();
                            Console.WriteLine("Do you want continue?");
                            Console.WriteLine("1.yes");
                            Console.WriteLine("2.no");
                            int con1 = Convert.ToInt32(Console.ReadLine());
                            if(con1 == 1)
                            { continue; }
                            else if(con1 == 2)
                            {
                                running = false;
                            }
                            else
                            {
                                Console.WriteLine("Choose from the options");
                            }
                        }
                        else if (Print_Choice == 2)
                        {
                            Product.Print();
                            Console.WriteLine("Do you want continue?");
                            Console.WriteLine("1.yes");
                            Console.WriteLine("2.no");
                            int con1 = Convert.ToInt32(Console.ReadLine());
                            if (con1 == 1)
                            { continue; }
                            else if (con1 == 2)
                            {
                                running = false;
                            }
                            else
                            {
                                Console.WriteLine("Choose from the options");
                            }
                        }
                        else if (Print_Choice == 3)
                        {
                            Transaction.print();
                            int con1 = Convert.ToInt32(Console.ReadLine());
                            if (con1 == 1)
                            { continue; }
                            else if (con1 == 2)
                            {
                                running = false;
                            }
                            else
                            {
                                Console.WriteLine("Choose from the options");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Choose from the options");
                        }
                        break;
                    case 4:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Enter one of the four options");
                        Thread.Sleep(3000);
                        break;
                }






            }
        }


        public static void DataEntry_Customer()
        {
            int choice_1;
            Console.Clear();
            Console.WriteLine("1. ADD");
            Console.WriteLine("2. Edit");
            Console.WriteLine("3. Delete");
            Console.WriteLine("Choose the number of the operation you want to do");
            choice_1 = Convert.ToInt32(Console.ReadLine());
            switch(choice_1)
            {
                case 1:
                    int choice_1_1;
                    Console.Clear();
                    Console.WriteLine("1. Company");
                    Console.WriteLine("2. Person");
                    Console.WriteLine("What the type of the customer? (Enter the number)");
                    choice_1_1 = Convert.ToInt32(Console.ReadLine());
                    switch(choice_1_1)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("What the Company Name?");
                            String Comapany_name=Console.ReadLine();
                            Console.WriteLine("What the Company Address");
                            String Company_address=Console.ReadLine();
                            Console.WriteLine("What the Company Id");
                            int Company_id=Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("What is the Company Phone");
                            String Company_phone = Console.ReadLine();
                            Customer customer = new Customer(true, Comapany_name, Company_address, Company_id, Company_phone);
                            Customers.AddCustomer(customer);
                            Console.WriteLine("The Customer is Added");
                            break;
                            case 2:
                            Console.Clear();
                            Console.WriteLine("What the Person Name?");
                            String Person_name = Console.ReadLine();
                            Console.WriteLine("What the Person Address");
                            String Person_address = Console.ReadLine();
                            Console.WriteLine("What the Person Id");
                            int Person_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("What is the Person Phone");
                            String Person_phone = Console.ReadLine();
                            Customer person = new Customer(false, Person_name, Person_address, Person_id, Person_phone);
                            Customers.AddCustomer(person);
                            Console.WriteLine("The Customer is Added");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Enter one of the options");
                            break;
                    }
                    break;
                case 2:
                    int choice_1_2;
                    Console.Clear();
                    Console.WriteLine("1. Company");
                    Console.WriteLine("2. Person");
                    Console.WriteLine("What the type of the customer? (Enter the number)");
                    choice_1_2 = Convert.ToInt32(Console.ReadLine());
                    switch (choice_1_2)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("What the Company Id you want to edit?");
                            int Company_id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("What the Company NEW Name?");
                            String Comapany_name = Console.ReadLine();

                            Console.WriteLine("What the Company NEW Address");
                            String Company_address = Console.ReadLine();
                            
                            Console.WriteLine("What is the Company NEW Phone");
                            String Company_phone = Console.ReadLine();
                            Customers.EditCustomer(true, Comapany_name, Company_address, Company_id, Company_phone);
                            Console.WriteLine("The Customer is Updated");


                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("What the Person Id to edit");
                            int Person_id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("What the Person NEW Name?");
                            String Person_name = Console.ReadLine();

                            Console.WriteLine("What the Person NEW Address");
                            String Person_address = Console.ReadLine();

                            

                            Console.WriteLine("What is the Person NEW Phone");
                            String Person_phone = Console.ReadLine();
                            Customers.EditCustomer(false, Person_name, Person_address, Person_id, Person_phone);
                            Console.WriteLine("The Customer is Updated");

                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Enter one of the options");
                            break;
                    }
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("1. Company");
                    Console.WriteLine("2. Person");
                    Console.WriteLine("What the type of the customer? (Enter the number)");
                    int i = Convert.ToInt32(Console.ReadLine());
                    if(i==1)
                    {
                        Console.Clear();
                        Console.WriteLine("What is the Company Id you want to delete?");
                        int Com_ID = Convert.ToInt32(Console.ReadLine());
                        Customers.DeleteCustomer(true,Com_ID);
                        Console.WriteLine("The Customer is Deleted");
                    }
                    else if(i==2)
                    {
                        Console.Clear();
                        Console.WriteLine("What is the Person Id you want to delete?");
                        int Per_ID = Convert.ToInt32(Console.ReadLine());
                        Customers.DeleteCustomer(false, Per_ID);
                        Console.WriteLine("The Customer is Deleted");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Enter one of the options");
                    }

                    break;
                    default :
                    Console.Clear();
                    Console.WriteLine("Enter one of the options");
                    break;
            }
        }

        /*--------------------*/
        public static void DataEntry_Stock()
        {
            int choice_1;
            Console.Clear();
            Console.WriteLine("1. ADD");
            Console.WriteLine("2. Edit");
            Console.WriteLine("3. Delete");
            Console.WriteLine("Choose the number of the operation you want to do");
            choice_1 = Convert.ToInt32(Console.ReadLine());
            switch (choice_1)
            {
                case 1:
                            Console.Clear();
                            Console.WriteLine("What the Product Name?");
                            String Product_Name = Console.ReadLine();
                            Console.WriteLine("What the Product Price");
                            double Product_Price = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("What the Product Id");
                            int Product_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("What is the Product Qunatity");
                            int Product_Quantity = Convert.ToInt32(Console.ReadLine());
                            Product product = new Product(Product_id,Product_Name,Product_Price,Product_Quantity);
                            Stock.AddStock(product);
                    Console.WriteLine("The Product is Added");


                    break;
                case 2:

                    {

                        Console.Clear();
                        Console.WriteLine("What is the Product Id to you want to edit");
                        int pro_id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("What the New Product Name?");
                        String Pro_Name = Console.ReadLine();

                        Console.WriteLine("What the New Product Price");
                        double Pro_Price = Convert.ToDouble(Console.ReadLine());

                       

                        Console.WriteLine("What is the New Product Qunatity");
                        int Pro_Quantity = Convert.ToInt32(Console.ReadLine());

                        Product.Update(pro_id, Pro_Name, Pro_Price, Pro_Quantity);
                        Console.WriteLine("The Product is Updated");

                    }
                    break;

                case 3:
                    Console.Clear();
                    
                    
                        
                        Console.WriteLine("What is the Product Id you want to delete?");
                        int PRO_ID = Convert.ToInt32(Console.ReadLine());
                        Product product_Delete= Stock.Search_Product(PRO_ID);
                        Stock.DeleteStock(product_Delete);
                        Console.WriteLine("The Product is Delete");


                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Enter one of the options");
                    break;
            }
        }

        /*----------------------------*/
        public static void Sales_Process(int choice, bool running, Customer customer, Transaction transaction , Order order)
        {
            
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("1. Company");
                    Console.WriteLine("2. Person");
                    Console.WriteLine("What the type of the customer? (Enter the number)");
                    int type = Convert.ToInt32(Console.ReadLine());
                    if (type == 1)
                    {
                        Console.WriteLine("What is the Company Id");
                        int company_id= Convert.ToInt32(Console.ReadLine());
                         customer = Customers.Company_Search(company_id);
                        
                    }
                    else if (type == 2)
                    {
                        Console.WriteLine("What is the Person Id");
                        int person_id = Convert.ToInt32(Console.ReadLine());
                         customer =Customers.Person_Search(person_id);
                    }
                    else
                    {
                        Console.WriteLine("Choose from the options");
                        Continue(running);
                    }

                    Console.WriteLine("What the status of the Order");
                    Console.WriteLine("1.NEW");
                    Console.WriteLine("2.HOLD");
                    Console.WriteLine("3.PAID");
                    Console.WriteLine("4.CANCELLED");
                    Console.WriteLine("Choose from the options");
                    int stata = Convert.ToInt32(Console.ReadLine());
                    if( stata != 1&& stata!=2&& stata!=3&& stata!=4 )
                    {
                        Console.WriteLine("Choose from the options");
                        Continue(running);
                    }
                    if(type == 1)
                    {
                         order = new Order(customer.id_company,stata);
                    }
                    else if(type == 2)
                    {
                         order = new Order(customer.id_person, stata);
                    }
                    else
                    {
                        Console.WriteLine("Choose from the options");
                        Continue(running);
                    }


                    Console.Write(" What is the product ID? ");
                    int Product_ID =Convert.ToInt32(Console.ReadLine());

                    Product product = Stock.Search_Product(Product_ID);

                    Console.Write(" What is the quantity? ");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    if (quantity >product.Product_Quantity)
                    {
                        Console.WriteLine("Not enough stock available.");
                        return;
                    }
                    OrderItem orderItem = new OrderItem(quantity,product);

                    if (type == 1)
                    {
                         transaction = new Transaction(customer.id_company);
                    }
                    else if (type == 2)
                    {
                        transaction = new Transaction(customer.id_person);
                    }
                    else
                    {
                        Console.WriteLine("Choose from the options");
                        Continue(running);
                    }

                    Transaction.transactions.Add(transaction);
                    Transaction.GetOrder(order);
                    Console.WriteLine("THE ORDER IS ADDED");

                    break;

                case 2:
                    Console.Clear();
                    Console.Write("What is the Order's Customer ID to update? ");
                    int Customer_ID = Convert.ToInt32(Console.ReadLine());

                    order =Transaction.Search_Order(Customer_ID);
                    Console.WriteLine("What to you want to uodate?");
                    Console.WriteLine("1.Order Status ");
                    Console.WriteLine("2.Order Quantity or New Product ");
                    int order_update = Convert.ToInt32(Console.ReadLine());

                    if(order_update ==1)
                    {
                        Console.Clear();
                        Console.WriteLine("What the NEW status of the Order");
                        Console.WriteLine("1.NEW");
                        Console.WriteLine("2.HOLD");
                        Console.WriteLine("3.PAID");
                        Console.WriteLine("4.CANCELLED");
                        Console.WriteLine("Choose from the options");
                        int stat = Convert.ToInt32(Console.ReadLine());
                        if (stat != 1 && stat != 2 && stat != 3 && stat != 4)
                        {
                            Console.WriteLine("Choose from the options");
                            Continue(running);
                        }
                        order.UpdateOrderStatus(stat);
                    }
                    else if(order_update ==2)
                    {
                        Console.Clear();
                        Console.WriteLine("What is the Product Id");
                        int productId = Convert.ToInt32(Console.ReadLine());
                        product =Stock.Search_Product(productId);

                        Console.Write(" What is the new quantity? ");
                        int quant = Convert.ToInt32(Console.ReadLine());

                        if (quant > product.Product_Quantity)
                        {
                            Console.WriteLine("Not enough stock available.");
                            return;
                        }

                        var Item = order.orderItems.Find(i=> i.Product.Product_Id==productId);
                        if (Item != null)
                        {
                            Item.Update_Quantity(quant);
                            Console.WriteLine("Updated quantity in existing order item.");
                        }
                        else
                        {
                            OrderItem item = new OrderItem(quant, product);
                            order.Add_OrderItem(item);
                            Console.WriteLine("Added new item to order.");
                        }


                    }
                    else
                    {
                        Console.WriteLine("Choose from the options");
                        Continue(running);

                    }


                   

                    break;

                case 3:
                    Console.Clear();
                    Console.Write("What is the Transaction's Customer ID to update? ");
                    int Customer_ID_paying = Convert.ToInt32(Console.ReadLine());
                    order = Transaction.Search_Order(Customer_ID_paying);

                    if((int)order.orderStatus==3)
                    {
                        Console.WriteLine("Order is already paid.");
                        Continue(running);
                    }
                    else
                    {
                        Console.WriteLine("1. Cash");
                        Console.WriteLine("2. Credit");
                        Console.WriteLine("3. Check");
                        Console.Write("Choose an option: ");
                        int paying = Convert.ToInt32(Console.ReadLine());


                        switch(paying)
                        {

                            case 1:
                                double cashAmount = order.Order_price;
                                Console.Write($"Enter cash value beware that the total amount is"+cashAmount+":");
                                double value = Convert.ToDouble(Console.ReadLine());

                                Cash cash = new Cash(value);
                                Transaction.AddPayment(cash,order);
                                break;

                            case 2: 
                                double creditAmount = order.Order_price;
                                Console.Write("Enter card number: ");
                                string number = Console.ReadLine();
                                Console.Write("Enter expiry date (MM/YY): ");
                                DateTime expiry;
                                while (!DateTime.TryParse(Console.ReadLine(), out expiry))
                                {
                                    Console.Write("Invalid date. Enter again (MM/YY): ");
                                }
                                Console.Write("Enter card type (Visa, Mastercard, etc.): ");
                                string type_credit = Console.ReadLine();

                                Credit credit = new Credit(number,expiry,type_credit,creditAmount);
                                Transaction.AddPayment(credit, order);
                                break;
                            case 3: 
                                double checkAmount = order.Order_price;
                                Console.Write("Enter account holder name: ");
                                string name = Console.ReadLine();
                                Console.Write("Enter Bank ID: ");
                                string bankId = Console.ReadLine();

                                Check check = new Check( name, checkAmount,bankId);
                                Transaction.AddPayment(check,order);
                                break;

                        }


                    }



                    break;

                    default:
                    Console.WriteLine("Choose from the options");
                    
                    break;


            }    
        }

        public static void Continue(bool running)
        {
            Console.WriteLine("Do you want continue?");
            Console.WriteLine("1.yes");
            Console.WriteLine("2.no");
            int con1 = Convert.ToInt32(Console.ReadLine());
            if (con1 == 1)
            {  }
            else if (con1 == 2)
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Choose from the options");
            }
        }
    }
}
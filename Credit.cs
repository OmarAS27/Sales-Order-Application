using System;

public class Credit: Payment
{
    public string Credit_Number { get; set; }
    
    public DateTime ExpireDate { get; set; }
    public string Credit_Type { get; set; }

    public double Credit_Amount { get; set; }
    public Credit(string credit_Number, DateTime expireDate, string credit_Type, double credit_Amount):base(credit_Amount)
    {
       
        this.ExpireDate = expireDate;
        this.Credit_Type = credit_Type;
        Credit_Amount = credit_Amount;
    }
}


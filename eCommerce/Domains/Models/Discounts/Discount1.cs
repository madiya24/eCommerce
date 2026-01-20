using System;

namespace eCommerce.Domains.Models.Discounts;

public abstract class Discount1
{
    public string discountCode {get; set;}
    public DateTime ValidForm {get; set;}
    public DateTime ValidTo {get; set;}

    //create an abstract method
    public abstract decimal ApplayDiscount(decimal originalPrice);

    // check is dicount is valid
    public bool IsValid()
    {
        return DateTime.Now >= ValidForm && DateTime.Now <= ValidTo;
    }
}

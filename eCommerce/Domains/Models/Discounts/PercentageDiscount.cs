using System;
using eCommerce.Domains.Models.Discounts;

namespace eCommerce.Domains.Models.Discount;

public class PercentageDiscount: Discount1
{
    public decimal percentageOff {get; set;}// 

    public override decimal ApplayDiscount(decimal originalPrice)
    {
        if (!IsValid())
            return originalPrice;
        
        decimal discountAmount = originalPrice * (percentageOff/100);
        return originalPrice - discountAmount;

    }

    

}

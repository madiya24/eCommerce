using System;
using eCommerce.Domains.Models.Discounts;

namespace eCommerce.Domains.Models.Discount;

public class FixedAmountDiscount: Discount1
{
    public decimal DiscountAmount { get; set; }

    public override decimal ApplayDiscount(decimal originalPrice)
    {
        if (!IsValid())
                return originalPrice;

            decimal finalPrice = originalPrice - DiscountAmount;
            return finalPrice < 0 ? 0 : finalPrice;
    }

}

using System;
using eCommerce.Domains.Models.Discount;

namespace eCommerce.Domains.Interfaces;

public interface IDiscountable
{
    decimal ApplyDiscount(Discount discount);
}

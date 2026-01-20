using System;
using eCommerce.Domains.Models.Shipping;

namespace eCommerce.Domains.Interfaces;

public interface IsShippable
{
    decimal CalculateShippingCost(Shipping1 shippingMethod);
}

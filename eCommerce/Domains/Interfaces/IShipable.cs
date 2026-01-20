using System;
using eCommerce.Domains.Models.Shipping;

namespace eCommerce.Domains.Interfaces;

public interface IShipable
{
    decimal CalculateShippingCost(Shipping shippingMethod);
}

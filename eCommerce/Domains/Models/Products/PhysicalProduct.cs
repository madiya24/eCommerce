using System;
using eCommerce.Domains.Interfaces;
using eCommerce.Domains.Models.Discounts;
using eCommerce.Domains.Models.Shipping;

namespace eCommerce.Domains.Models;

public class PhysicalProduct : Products , IsShippable 

{
    public double weight {get; set;} // int kg
    public string dimenssions {get;set;}
    public string color {get; set;}
    public string size {get; set;}

    public override decimal CalculateFinalPrice(Discount1 discount = null)
    {
        decimal finalPrice = price;
        if(discount != null && discount.IsValid())
        {
            finalPrice = discount.ApplayDiscount(price);
        }
        return finalPrice;
    }

    public decimal CalculateShippingCost(Shipping1 shippingMethod)
    {
        return shippingMethod.CalculateCost(weight);
    }

    public override string GetProductDetails()
    {
        return base.GetProductDetails() + $" | Weight: {weight}Kg | Color: {color} | Size: {size}";
    }

    public override bool IsAvailable()
    {
        return stockQuantity > 0;
    }
}

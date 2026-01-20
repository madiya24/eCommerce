using System;
using System.Data;
using eCommerce.Domains.Enums;
using eCommerce.Domains.Models.Discounts;

namespace eCommerce.Domains.Models;

public abstract class Products
{
    public int prodictId{get; set;}
    public String name {get; set;}
    public string decription {get; set;}
    public decimal price {get; set;}
    public int stockQuantity {get; set;}
    public ProductCategory Category {get; set;} //
    public  string brand {get; set;}
    public DateTime DateAdded {get;}
    public double rating {get; set;}

    // constuctor
    protected Products()
    {
        DateAdded = DateTime.Now;
        rating = 0.0;
    }

    //create an abstract methods
    public abstract decimal CalculateFinalPrice(Discount1 discount = null);
    public abstract bool IsAvailable();

    // create a virtual method
    public virtual string GetProductDetails()
    {
        return$"ID: {prodictId} | {name} | ${price} | Stock: {stockQuantity} | Category: {Category}";
    }

    // update stock after purchase
    public void ReducStock(int quantity)
    {
        if(quantity <= stockQuantity)
        {
            stockQuantity -= quantity;
        }
        else
        {
            throw new InvalidOperationException ("Insufficient stock!");
        }
    }
    // restock
    public void AddStock(int quantity)
    {
        stockQuantity += quantity;
    }
}

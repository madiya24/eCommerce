using System;
using eCommerce.Domains.Enums;

namespace eCommerce.Domains.Models.Shipping;

public abstract class Shipping1
{
    public int shippingId {get;set;}
    public string trackingNumber{get; set;}
    public ShippingStatus status {get;set;}
    public DateTime estimatedDelivery {get;set;}

    // Abstract methods
        public abstract decimal CalculateCost(double weight);
        public abstract int GetDeliveryDays();

        protected Shipping1()
        {
            status = ShippingStatus.Pending;
            trackingNumber = GenerateTrackingNumber();
        }

        private string GenerateTrackingNumber()
        {
            return "TRK" + DateTime.Now.Ticks.ToString().Substring(0, 10);
        }
}

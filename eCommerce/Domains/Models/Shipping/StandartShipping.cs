using System;

namespace eCommerce.Domains.Models.Shipping;

public class StandartShipping: Shipping1
{
    public override decimal CalculateCost(double weight)
        {
            // $5 base + $1 per kg
            return 5m + (decimal)weight * 1m;
        }

        public override int GetDeliveryDays()
        {
            return 7; // WITHIN 7 days
        }
}

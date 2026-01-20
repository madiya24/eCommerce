using System;

namespace eCommerce.Domains.Enums;

public enum PaymentStatus
{
    Pending,
    Processing,
    Completed,
    Failed,
    Refunded
}

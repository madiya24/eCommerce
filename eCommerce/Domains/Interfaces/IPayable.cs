using System;

namespace eCommerce.Domains.Interfaces;

public interface IPayable
{
    bool ProcesssPayment();
}

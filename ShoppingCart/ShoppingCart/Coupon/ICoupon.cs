﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Coupon
{
    public interface ICoupon
    {
        bool IsValidCoupon(double amount);
        double Discount(double amount);
    }
}

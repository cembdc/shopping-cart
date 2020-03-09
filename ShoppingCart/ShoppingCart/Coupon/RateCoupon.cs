﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Coupon
{
    public class RateCoupon: ICoupon
    {
        private double _couponValue;
        private int _minCartAmount;

        public RateCoupon(double couponValue, int minCartAmount)
        {
            _couponValue = couponValue;
            _minCartAmount = minCartAmount;
        }

        public double Discount(double amount)
        {
            double discount = 0;

            if (amount <= 0)
                return discount;

            return amount * (_couponValue * 0.01);
        }

        public bool IsValidCoupon(double amount)
        {
            return amount >= _minCartAmount;
        }
    }
}

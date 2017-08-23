using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.DIP_Example1
{
    public class Discount : IDiscount
    {
        public void CalculateDiscountedValue()
        {
            throw new NotImplementedException();
        }

        //public float CalculateDiscountedValue(Order orderDetail)
        //{
        //    float discountedValue = 2;
        //    return discountedValue;
        //}
    }
}
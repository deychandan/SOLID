using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.DIP_Example1
{
    public class VAT : IVAT
    {
        //public float CalculateVATValue(Order orderDetail)
        //{
        //    float vatValue = 5;
        //    return vatValue;
        //}
        public void CalculateVATValue()
        {
            throw new NotImplementedException();
        }
    }
}
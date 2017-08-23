using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.DIP_Example1
{
    public class Invoice_DIP
    {
        private IDiscount discountCalculator;
        private IVAT vatCalculator;

        public Invoice_DIP(IDiscount discountCalculator, IVAT vatCalculator)
        {
            this.discountCalculator = discountCalculator;
            this.vatCalculator = vatCalculator;
        }

        public float PrepareInvoice(Order orderDetail)
        {
            //float discount = this.discountCalculator.CalculateDiscountedValue(orderDetail);
            //float vat = this.vatCalculator.CalculateVATValue(orderDetail);
            this.discountCalculator.CalculateDiscountedValue();
            this.vatCalculator.CalculateVATValue();

            //return orderDetail.Amount - discount + vat;
            return 0;
        }
    }
}
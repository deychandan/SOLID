using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.DIP_Example1
{
    public class Invoice_NODIP
    {
        private Discount discountCalculator;
        private VAT vatCalculator;

        public Invoice_NODIP(Discount discountCalculator, VAT vatCalculator)
        {
            this.discountCalculator = discountCalculator;
            this.vatCalculator = vatCalculator;
        }

        public float PrepareInvoice(Order orderDetail)
        {
            float discount = this.discountCalculator.CalculateDiscountedValue(orderDetail);
            float vat = this.vatCalculator.CalculateVATValue(orderDetail);

            return orderDetail.Amount - discount + vat;
        }
    }
}
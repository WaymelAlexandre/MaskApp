using System;

namespace MaskApi.models
{
    public class Order{
        
        public int OrderNo { get; set; }
        public Mask Mask { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }

        public Order(int orderNo, Mask mask, int qty, double price)
        {
            this.OrderNo = this.GenOrderNo();
            this.Mask = mask;
            this.Qty = qty;
            this.setPrice();
        }
        public Order(){}

        public void setPrice()
        {
            this.Price = this.Qty * Mask.Cost;
            
        }

        public int GenOrderNo(){
            Random rand =new Random();
            return rand.Next
            (1000,10000);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceExercise
{
    internal class Invoice
    {
        
        public int InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; } //initialized it to DateTime.Now in constructor
        public DateTime PaymentDue { get; set; } //added payment due date
        public string CustomerName { get; set; }
        public Item[] Items { get; set; } //created a class Item and used it to create an array of Items  
        public decimal Subtotal
        {
            get
            {
                decimal subtotal = 0;
                foreach (var item in Items) //goes through each item to calculate the subtotal
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount
        {
            get
            {
                return Subtotal * (TaxRate / 100);
            }
        }
        public decimal TotalAmount
        {
            get
            {
                return Subtotal + TaxAmount;
            }
        }

        //added paymentDue and items to the constructor
        public Invoice(int invoiceNumber, DateTime paymentDue, string customerName, Item[] items, decimal taxRate) 
        {
            InvoiceNumber = invoiceNumber;
            InvoiceDate = DateTime.Now;
            PaymentDue = paymentDue;
            CustomerName = customerName;
            Items = items;
            TaxRate = taxRate;
            
        }
        public static decimal AddVAT(decimal amount, decimal vatAmount)
        {
            return amount * vatAmount;
        }

        //added paymentDue and items to the ToString method
        public override string ToString()
        {
            return $"Invoice\nInvoice Number: {InvoiceNumber}\nInvoice Date: {InvoiceDate}\nCustomer Name: {CustomerName}\nSubtotal: {Subtotal:C}\nTax Rate: {TaxRate}%\nTax Amount: {TaxAmount:C}\nPayment Due: {PaymentDue}\nTotal Amount: {TotalAmount:C}";
        }
        
        
    }
}

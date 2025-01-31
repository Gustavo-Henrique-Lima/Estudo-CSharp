﻿using System.Globalization;

namespace Pedido.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product? Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name + ", $" + Product.Price.ToString("F2", CultureInfo.InvariantCulture)
                + " Quantity: " + Quantity + ", Subtotal: $" + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

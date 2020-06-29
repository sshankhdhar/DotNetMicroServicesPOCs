using System;

namespace OrdersApi {
    public class Order {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public Order (string id, decimal amount) {
            Id = id;
            Amount = amount;
        }
    }
}
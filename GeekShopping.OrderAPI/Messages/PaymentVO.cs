﻿using GeekShopping.MessageBus;

namespace GeekShopping.OrderAPI.Messages
{
    public class PaymentVO : BaseMessage
    {
        public long OrderId { get; set; }
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public string CVV {  get; set; }
        public string ExpiryMonthYear {  get; set; }
        public string ExpiryYear { get; set; }
        public string Email { get; set; }
    }
}

using System;

namespace AutoMapperDemo
{
    class InputOrder
    {
        public string OrderID { get; set; }
        public DateTime OrderCreatedDateTime { get; set; }

        public InputOrder BuildInputOrder()
        {
            return new InputOrder
            {
                OrderID = "123-345QA",
                OrderCreatedDateTime = DateTime.Now
            };
        }
    }
}

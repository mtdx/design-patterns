﻿namespace Strategy.Domain
{
    public class Order
    {
        public Address Destination { get; set; }
        public Address Origin { get; set; }
    }
}
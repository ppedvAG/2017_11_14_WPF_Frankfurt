using System;

namespace Templates
{
    internal class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }

    internal class Customer : Person
    {
        public int CountOrders { get; set; }
    }

    internal class Employee : Person
    {
        public int Salary { get; set; }
    }
}

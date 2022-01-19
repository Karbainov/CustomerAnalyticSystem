﻿using CustomerAnalyticSystem.DAL.Interfaces;

namespace CustomerAnalyticSystem.DAL.DTOs
{
    public class CustomerDTO : IBaseCustomer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TypeId { get; set; }

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName} {TypeId}";
        }
    }
}

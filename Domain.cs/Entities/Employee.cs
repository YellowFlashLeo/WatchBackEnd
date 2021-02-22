﻿using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Employee : AuditableEntity
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
            DirectReports = new HashSet<Employee>();
        }

        public int EmployeeId { get; set; }
        public string UserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public int? ReportsTo { get; set; }
        public string PhotoPath { get; set; }

        public Employee Manager { get; set; }
        public ICollection<Order> Orders { get; private set; }
        public ICollection<Employee> DirectReports { get; private set; }
    }
}

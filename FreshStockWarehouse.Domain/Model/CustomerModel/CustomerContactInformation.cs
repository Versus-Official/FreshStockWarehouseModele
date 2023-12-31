﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Domain.Model.CustomerModel
{
    public class CustomerContactInformation
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public int CustomerRef { get; set; }

        public Customers Customers { get; set; }
    }
}

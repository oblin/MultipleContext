using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JagiCore.Core;

namespace MultipleContext.Sales
{
    public class Address : ValueObject<Address>
    {
        public string Street { get; set; }
        public string City { get; set; }
    }
}

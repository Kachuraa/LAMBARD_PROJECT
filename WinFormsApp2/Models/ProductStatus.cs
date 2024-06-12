using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    internal class ProductStatus
    {
        public static readonly ProductStatus Available = new ProductStatus("Available");
        public static readonly ProductStatus Sold = new ProductStatus("Sold");
        public static readonly ProductStatus Returned = new ProductStatus("Returned");

        public string Name { get; }

        private ProductStatus(string name)
        {
            Name = name;
        }
    }
}


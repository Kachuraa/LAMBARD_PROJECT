using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class Product
    {
        public string Name { get; }
        public decimal EstimatedValue { get; }
        public decimal PawnValue { get; }
        public DateTime DateReceived { get; }
        public int StoragePeriod { get; }

        public Product(string name, decimal estimatedValue, decimal pawnValue, DateTime dateReceived, int storagePeriod, decimal price, DateTime expiryDate)
        {
            Name = name;
            EstimatedValue = estimatedValue;
            PawnValue = pawnValue;
            DateReceived = dateReceived;
            StoragePeriod = storagePeriod;
        }

        public override string ToString()
        {
            return $"{Name} (Estimated: {EstimatedValue}, Pawn: {PawnValue}, Date: {DateReceived.ToShortDateString()}, Period: {StoragePeriod} days)";
        }
    }
}
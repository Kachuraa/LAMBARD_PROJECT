using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace WinFormsApp2.Models
{
    public class PawnShop
    {
        public List<ClientProductPair> ClientProductPairs { get; set; }

        public PawnShop()
        {
            ClientProductPairs = new List<ClientProductPair>();
            
        }

        public void AddClientProductPair(Client client, Product product)
        {
            if (client == null || product == null)
            {
                throw new ArgumentException("Client and Item cannot be null");
            }

            ClientProductPairs.Add(new ClientProductPair(client, product));
        }

        private const string FileName = "pawnshop.json";

        public void SaveData()
        {
            var jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(FileName, jsonString);
        }

        public static PawnShop? LoadData()
        {
            if (File.Exists(FileName))
            {
                var jsonString = File.ReadAllText(FileName);
                return JsonSerializer.Deserialize<PawnShop>(jsonString);
            }
            return null;
        }

        internal void RemoveClientProductPair(Product selectedProduct)
        {
            throw new NotImplementedException();
        }
    }
}
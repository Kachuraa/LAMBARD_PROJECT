using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class ClientProductPair
    {
        [JsonInclude]
        public Client Client { get; set; }

        [JsonInclude]
        public Product Product { get; set; }

        public ClientProductPair(Client client, Product product)
        {
            Client = client ?? throw new ArgumentNullException(nameof(client));
            Product = product ?? throw new ArgumentNullException(nameof(product));
        }
    }
}
using Newtonsoft.Json;

namespace WebApiDemo.Core.Entities
{
    public class ProductDetails
    {
        public int ID { get; set; }

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "Price")]
        public double? Price { get; set; }

        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "IsPublished")]
        public bool Published { get; set; }
    }
}

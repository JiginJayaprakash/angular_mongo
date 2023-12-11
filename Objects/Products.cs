using MongoDB.Bson;

namespace angular_mongo.Objects
{
	public class Product
	{

		public ObjectId product_id { get; set; }
		public string description { get; set; } = null!;
		public bool is_enabled { get; set; } = true;
		public DateTime created_date { get; set; } = DateTime.UtcNow;

		public Product(string description)
		{
			this.description = description;
		}

	}
}

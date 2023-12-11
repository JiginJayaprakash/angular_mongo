using MongoDB.Driver;
using MongoDB.Bson;
using angular_mongo.Objects;

namespace angular_mongo.DataLayer
{
    public class ProductData
    {
        const string connectionUri = "mongodb+srv://jayaprakashjigin:j7oQyf3L4q7gvT0b@cluster0.dhenovx.mongodb.net/?retryWrites=true&w=majority";
        private dynamic productCollection;
        public ProductData()
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            // Set the ServerApi field of the settings object to Stable API version 1
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            // Create a new client and connect to the server
            var client = new MongoClient(settings);
            // Send a ping to confirm a successful connection
            try
            {
                var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            productCollection = client.GetDatabase("product").GetCollection<Product>("product");
        }

        public bool Save(string description)
        {
            try
            {
                productCollection.InsertOne(new Product(description));
                return true;
            }
            catch(Exception ex)
            {
                
            }
            return false;
            
        }

        public List<Product> GetAll()
        {
            List<Product> results = productCollection.ToList();
            return results;
        }
        
    }
}
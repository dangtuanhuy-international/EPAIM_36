namespace Examination.Infrastructure.SeedWork
{
    public class ExamSettings
    {
        public string IdentityUrl = "https://localhost:5001/";

        public DatabaseSettings DatabaseSettings { get; set; }
    }

    public class DatabaseSettings
    {
        public string ConnectionString = "mongodb://anpham07:9egGepiIECD137lrktOPltt5NoKunCfZA5qwamucE7mgqMEJW3DFEadLhU9cXg4QCz4ZO1xMhdyrDxxpWkHfKw==@anpham07.mongo.cosmos.azure.com:10255/?ssl=true&replicaSet=globaldb&retrywrites=false&maxIdleTimeMS=120000&appName=@anpham07@";
        public string DatabaseName = "ExamLock";
    }
}
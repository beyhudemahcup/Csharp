namespace Interface_ders
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
          //  throw new NotImplementedException();
            Console.WriteLine("database'e yazar");
        }
    }
}
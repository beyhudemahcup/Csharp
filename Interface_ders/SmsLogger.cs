namespace Interface_ders
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("sms logu burada");
        }
    }
}
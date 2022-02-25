namespace Interface_ders
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FIleLogger fileLogger = new FIleLogger();
            DatabaseLogger databaseLogger = new DatabaseLogger();
            SmsLogger smsLogger = new SmsLogger();

            fileLogger.WriteLog();
            databaseLogger.WriteLog();
            smsLogger.WriteLog();
            //bunlari bu sekilde yazmak yerine bir log manager ile butun call islemini gerceklestirebiliriz

            LogManager logManager = new LogManager(new FIleLogger());
            logManager.WriteLog();
        }
    }
}
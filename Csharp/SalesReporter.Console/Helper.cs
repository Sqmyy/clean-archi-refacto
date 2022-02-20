namespace SalesReporterKata
{
    public static class Helper
    {
        public static void printHelp()
        {
            Console.WriteLine("[ERR] your command is not valid ");  
			Console.WriteLine("Help: ");  
			Console.WriteLine("    - [print]  : show the content of our commerce records in data.csv");  
			Console.WriteLine("    - [report] : show a summary from data.csv records ");  
        }
    }
}
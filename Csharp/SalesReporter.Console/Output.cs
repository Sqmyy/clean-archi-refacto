using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesReporterKata
{
    public static class Output
    {
        //add a title to our app
        public static void printAppTitle() 
        {
            Console.WriteLine("=== Sales Viewer ===");
        }

        //add a border for the table
        public static void printBorder(String completeHeader)
        {
            Console.WriteLine("+" + new String('-', completeHeader.Length + 2) + "+");
        }

        //render the titles format
        public static void printTitles( String completeHeader)
        {
            Console.WriteLine("| " + completeHeader + " |");
        }

        // render the complete header
        public static void printHeader(String titleInString)
        {
            printBorder(titleInString);
            printTitles(titleInString);
            printBorder(titleInString);
        }
        public static void printData(IEnumerable<string> allLinesData)
        {
            //then add each line to the table  
            foreach (string line in allLinesData)  
            { 
                //extract columns from our csv line and add all these cells to the line  
                var cells = line.Split(',');
                var tableLine  = String.Join(
                    " | ", 
		            
                    line.Split(',').Select(
                        (val,ind) => val.PadLeft(16)));
                Console.WriteLine($"| {tableLine} |");
            } 
        }

        public static void renderPrintFormat(
            List<(int index, int size, string name)> allTitles,
            IEnumerable<string> allLinesData )
        {
            var headerString = String.Join(
                " | ",
                allTitles.Select(x => x.name)
                    .Select(
                        (val,ind) => val.PadLeft(16)));
            printAppTitle();
            printHeader(headerString);
            printData(allLinesData);
            printBorder(headerString);
        }

        public static void printSummary(Dictionary<string, string> dataReport)
        {
            printAppTitle();
            Console.WriteLine($"+{new String('-',45)}+");
            foreach(KeyValuePair<string, string> entry in dataReport)
            {
                Console.WriteLine($"| {entry.Key.PadLeft(30)} | {entry.Value.PadLeft(10)} |");
            }
            Console.WriteLine($"+{new String('-',45)}+");
        }

        public static void printHelp()
        {
            Console.WriteLine("[ERR] your command is not valid ");  
			Console.WriteLine("Help: ");  
			Console.WriteLine("    - [print]  : show the content of our commerce records in data.csv");  
			Console.WriteLine("    - [report] : show a summary from data.csv records ");  
        }

    }
}
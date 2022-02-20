using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesReporterKata
{
    public static class Output
    {
        //add a title to our app
        private static void printAppTitle() 
        {
            Console.WriteLine("=== Sales Viewer ===");
        }

        //add a border for the table
        private static void printBorder(String completeHeader)
        {
            Console.WriteLine("+" + new String('-', completeHeader.Length + 2) + "+");
        }

        //render the titles format
        private static void printTitles( String completeHeader)
        {
            Console.WriteLine("| " + completeHeader + " |");
        }

        // render the complete header
        private static void printHeader(String titleInString)
        {
            printBorder(titleInString);
            printTitles(titleInString);
            printBorder(titleInString);
        }
        private static void printData(IEnumerable<string> allLinesData)
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

    }
}
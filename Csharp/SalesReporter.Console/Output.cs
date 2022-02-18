using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesReporterKata
{
    public static class Output
    {
        //add a title to our app
        public static void appTitle() 
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
        public static void printHeader(List<(int index, int size, string name)> titleList)
        {
            var headerString = String.Join(
                " | ",
                titleList.Select(x => x.name)
                    .Select(
                        (val,ind) => val.PadLeft(16)));
            printBorder(headerString);
            printTitles(headerString);
            printBorder(headerString);
        }
        public static void printData()
        {

        }

    }
}
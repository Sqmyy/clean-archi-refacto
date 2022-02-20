using System;
using System.Collections.Generic;
using System.IO;
using SalesReporterKata;

namespace SalesReporterKata
{
    public class Printer
    {
        public string getHeaderLine(string[] dataContentString)
        {
            return dataContentString[0];
        }

        public IEnumerable<string>? getDataLines(string[] dataContentString)
        {
            return dataContentString.Skip(1);
        }

        public List<(int index, int size, string name)> buildDataArray(string header)
        {
            var columnInfos = new List<(int index, int size, string name)>();
            int i = 0;

            foreach(var columName in header.Split(','))
            {
                columnInfos.Add((i++, columName.Length, columName));
            }

            return columnInfos;
        }

    }
}
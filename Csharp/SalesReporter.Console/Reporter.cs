using System.Collections.Generic;

namespace SalesReporterKata
{
    public class Reporter
    {
        public IEnumerable<string>? getDataLines(string[] dataContentString)
        {
            return dataContentString.Skip(1);
        }

        public Dictionary<string, string> getDataReport(string[] dataContentString)
        {
            HashSet<string> clients = new HashSet<string>();
            Dictionary<string, string> dataSummary = new Dictionary<string, string>();   
            int numberOfSales = 0, totalItemSold = 0, numberOfClients = clients.Count;
            double totalSalesAmount = 0.0, averageAmountPerSale = 0.0, averageItemPrice = 0.0;
            
            var dataLines = getDataLines(dataContentString);

            foreach(var line in dataLines)
            {
                var cells = line.Split(',');
                numberOfSales++;
                totalItemSold += int.Parse(cells[2]);
                totalSalesAmount += double.Parse(cells[3]);
            }
            averageAmountPerSale = Math.Round(totalSalesAmount / numberOfSales, 2);
            averageItemPrice += Math.Round(totalSalesAmount / totalItemSold, 2);
            
            dataSummary.Add(" Number of sales", numberOfSales.ToString());
            dataSummary.Add(" Number of clients", numberOfClients.ToString());
            dataSummary.Add(" Total items sold", totalItemSold.ToString());
            dataSummary.Add(" Total sales amount", Math.Round(totalSalesAmount, 2).ToString());
            dataSummary.Add(" Average amount/sale", averageAmountPerSale.ToString());
            dataSummary.Add(" Average item price", averageItemPrice.ToString());

            return dataSummary;
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SalesReporterKata;

public static class Program
{
	//lots of comments!
	public static void Main(string[] args)
	{
		//extract the command name from the args  
		string command = args.Length > 0 ? args[0] : "unknown";  
		string file = args.Length >= 2 ? args[1] : "./data.csv";
		//read content of our data file  
		//[2012-10-30] rui : actually it only works with this file, maybe it's a good idea to pass file //name as parameter to this app later?  
		string[] dataContentString = File.ReadAllLines(file);  
		//if command is print  
		if (command == "print")  
		{  
			var printer = new Printer();

			string header = printer.getHeaderLine(dataContentString);
			var dataLines = printer.getDataLines(dataContentString);
			var columnInfos = printer.buildDataArray(header);

			Output.renderPrintFormat(columnInfos, dataLines);
			// if command is report
		} 
		else if (command == "report")  
		{  
			var reporter = new Reporter();

			var dataLines = reporter.getDataLines(dataContentString);
			Dictionary<string, string> dataReport = reporter.getDataReport(dataContentString);
			
			Output.printSummary(dataReport);
		}  
		else  
		{  
 			Output.printHelp();
		}
	}
}

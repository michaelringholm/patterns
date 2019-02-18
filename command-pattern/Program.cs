using System;

namespace command_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running commands");
            CommandInvoker.InvokeCommand("PerformQuarterlyReportingCommand", new { ReportID=555444, MemberID=111 });
        }
    }
}

using System.Diagnostics;
using System.Dynamic;

public class PerformQuarterlyReportingCommand : ICommand {   
    public dynamic Execute(dynamic parameters) {
        var dynParams = (dynamic)parameters;
        Debug.WriteLine($"Performing Quarterly Reporting for report {dynParams.ReportID} and member {dynParams.MemberID}");
        return new { status = "success" };
    }
}
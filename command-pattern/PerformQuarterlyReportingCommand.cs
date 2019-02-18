using System.Diagnostics;

public class PerformQuarterlyReportingCommand : ICommand {   
    public dynamic Execute(dynamic parameters) {
        Debug.WriteLine($"Performing Quarterly Reporting for report {parameters.ReportID} and member {parameters.MemberID}");
        return new {};
    }
}
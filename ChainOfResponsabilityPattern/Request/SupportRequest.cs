namespace ChainOfResponsibilityPattern.Request;

public class SupportRequest
{
  public string CustomerName { get; }
  public string Issue { get; }
  public Complexity Complexity { get; }
  public bool IsResolved { get; set; }
  public string ResolvedBy { get; set; }

  public SupportRequest(string customerName, string issue, Complexity complexity)
  {
    CustomerName = customerName;
    Issue = issue;
    Complexity = complexity;
    IsResolved = false;
    ResolvedBy = null;
  }
}

public enum Complexity
{
  Low,
  Medium,
  High
}
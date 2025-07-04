namespace ChainOfResponsibilityPattern.Level;

using ChainOfResponsabilityPattern.Handler;
using ChainOfResponsibilityPattern.Request;

public class LevelTwoSupport : SupportHandler
{
  public override void Handle(SupportRequest request)
  {
    if (request.Complexity == Complexity.Medium)
    {
      request.IsResolved = true;
      request.ResolvedBy = "Level 2 Support";
      Console.WriteLine($"[Level 2] Resolved '{request.Issue}' for {request.CustomerName}.");
    }
    else
    {
      Console.WriteLine($"[Level 2] Escalating '{request.Issue}' for {request.CustomerName}.");
      base.Handle(request);
    }
  }
}
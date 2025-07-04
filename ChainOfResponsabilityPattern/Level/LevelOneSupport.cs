namespace ChainOfResponsibilityPattern.Level;

using ChainOfResponsabilityPattern.Handler;
using ChainOfResponsibilityPattern.Request;

public class LevelOneSupport : SupportHandler
{
  public override void Handle(SupportRequest request)
  {
    if (request.Complexity == Complexity.Low)
    {
      request.IsResolved = true;
      request.ResolvedBy = "Level 1 Support";
      Console.WriteLine($"[Level 1] Resolved '{request.Issue}' for {request.CustomerName}.");
    }
    else
    {
      Console.WriteLine($"[Level 1] Escalating '{request.Issue}' for {request.CustomerName}.");
      base.Handle(request);
    }
  }
}
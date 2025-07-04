namespace ChainOfResponsibilityPattern.Level;

using ChainOfResponsabilityPattern.Handler;
using Request;

public class LevelThreeSupport : SupportHandler
{
    public override void Handle(SupportRequest request)
    {
        if (request.Complexity == Complexity.High)
        {
            request.IsResolved = true;
            request.ResolvedBy = "Level 3 Support";
            Console.WriteLine($"[Level 3] Resolved '{request.Issue}' for {request.CustomerName}.");
        }
        else
        {
            Console.WriteLine($"[Level 3] Escalating '{request.Issue}' for {request.CustomerName}.");
            base.Handle(request);
        }
    }
}

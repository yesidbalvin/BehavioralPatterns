using ChainOfResponsibilityPattern.Request;

namespace ChainOfResponsabilityPattern.Handler;

public abstract class SupportHandler
{
  protected SupportHandler Next;

  public void SetNext(SupportHandler next)
  {
    Next = next;
  }

  public virtual void Handle(SupportRequest request)
  {
    if (Next != null)
    {
      Next.Handle(request);
    }
    else
    {
      Console.WriteLine($"[Unresolved] '{request.Issue}' could not be handled for {request.CustomerName}.");
    }
  }
}
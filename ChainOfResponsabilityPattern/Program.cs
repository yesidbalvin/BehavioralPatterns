// See https://aka.ms/new-console-template for more information
// Build the support chain: Level 1 -> Level 2 -> Level 3
using ChainOfResponsibilityPattern.Request;
using ChainOfResponsibilityPattern.Level;

var level1 = new LevelOneSupport();
var level2 = new LevelTwoSupport();
var level3 = new LevelThreeSupport();

level1.SetNext(level2);
level2.SetNext(level3);

// Create sample requests
var requests = new[]
{
                new SupportRequest("Alice", "Password reset", Complexity.Low),
                new SupportRequest("Bob", "Cannot access VPN", Complexity.Medium),
                new SupportRequest("Charlie", "Server down", Complexity.High),
                new SupportRequest("Diana", "Strange hardware failure", (Complexity)99) // Unhandled complexity

};

foreach (var req in requests)
{
  level1.Handle(req);
  if (req.IsResolved)
  {
    Console.WriteLine($"-> Handled by: {req.ResolvedBy}");
  }
  else
  {
    Console.WriteLine("-> Request could not be resolved.");
  }
  Console.WriteLine(new string('-', 50));
}

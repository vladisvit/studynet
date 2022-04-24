using LoginFinishExample.Interfaces;

namespace LoginFinishExample.Services.Logger
{
  internal class ConsoleMessageWriter : IMessageWriter
  {
    public void Write(string message)
    {
      Console.WriteLine($"MessageWriter.Write(message: \"{message}\")");
    }
  }
}

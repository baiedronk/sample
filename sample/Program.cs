namespace sample
{
  public class Program
  {
    private enum SomeOption
    {
      None = 0,
      Step1,
      Step2,
      FinalStep
    }

    private static void Main(string[] args)
    {
      var usedVar = "";
      var unusedVar = ""; // raise unused vars

      Console.WriteLine("Hello, World!");
      var some = new SomeClass() { Id = 1, Name = "sample" };

      // throw too many parameters in a function
      DoSomething(1, true, new string[1], SomeOption.None, DateTime.Now, 75, some, usedVar);
    }

    private static void DoSomething(int v1, bool v2, string[] strings, SomeOption none, DateTime now, int v3, SomeClass someClass, string someVar)
    {
      try
      {
        Console.WriteLine("We really dont want to throw exceptions, but for case in sample we will!");
      }
      catch (Exception)
      {
        throw new NotImplementedException();
      }
    }
  }
}

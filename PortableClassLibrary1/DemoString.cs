namespace PexDemo
{
  public class DemoString
  {
    public static void Xml(string value)
    {
      char sep = ',';
      if (value.StartsWith("//") && value.Length >= 3)
      {
        sep = value[3];
      }
    }
  }
}
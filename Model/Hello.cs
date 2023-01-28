namespace TestSetUp;

// example post docs
public class Hello
{
  public int Hola { get; set; }
  public int what { get; set; }

  public Hello(int hola, int what)
  {
    this.Hola = hola;
    this.what = what;
  }

  public string ToString()
  {
    return Hola.ToString() + " " + what.ToString();
  }
}

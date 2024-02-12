using static System.Console;
namespace Project1
{
    class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("Trying to Play A Note");
            Instrumento FenderStatocaster = new Guitarra();
            FenderStatocaster.PlayNote(440.0d);
            WriteLine("Trying to Play A Chord");
            Guitarra guitarra = (Guitarra)FenderStatocaster;
            guitarra.PlayChord(new double[] { 110.0d, 440.0d });
        }
    }
}
class Instrumento
{
    private string Nombre { get; set; }
    public Instrumento()
    {
        Nombre = "";
    }
    public virtual void PlayNote(double frequency)
    {
        WriteLine($"Reproduciendo Nota a {frequency} Hz");
    }
}
class InstrumentoCuerda : Instrumento
{
    protected int Cuerdas { get; set; }
    public InstrumentoCuerda()
    {
        Cuerdas = 0;
    }

    override public void PlayNote(double frequency)
    {
        WriteLine($"Reproduciendo Nota a {frequency} Hz Mediante una cuerda");
    }
}
class Guitarra : InstrumentoCuerda
{
    private string Tuning { get; set; }
    public Guitarra()
    {
        Tuning = "EADGBE";
        base.Cuerdas = 6;
    }

    override public void PlayNote(double frequency)
    {
        WriteLine($"Reproduciendo Nota a {frequency} Hz Tocando la Cuerda");
    }
    public void PlayChord(double[] frequencies)
    {
        foreach (var frequency in frequencies)
        {
            WriteLine($"Reproduciendo Nota a {frequency} Hz Tocando la Cuerda");
        }
    }
}
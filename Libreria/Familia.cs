namespace Libreria;

public class Familia
{
    public IEstado _estado;
    public double Ingresos { get; set; }
    public Familia(double ingresos)
    {
        _estado = new ClaseBaja();
        Ingresos = ingresos;
    }
    public void DefinirEstado(IEstado estado)
    {
        _estado = estado;
    }
    public void Presionar()
    {
        _estado.ControlarEstado(this);
        System.Console.WriteLine(_estado.Describir());
    }
    public void IngrementarIngresos(double monto)
    {
        Ingresos += monto;
    }
    public void DecrementarIngresos(double monto)
    {
        Ingresos -= monto;
    }
}

namespace Libreria;

public static class SelecionarEstado
{
    static List<IEstado> clases = new List<IEstado>() {new ClaseBaja(), new ClaseMedia(), new ClaseAlta()};
    public static IEstado AsignarEstado(Familia familia)
    {
        if (familia.Ingresos < 1000)
        {
            return clases[0];
        }
        else if (familia.Ingresos >= 1000 && familia.Ingresos <= 5000)
        {
            return clases[1];
        }
        else
        {
            return clases.Last();
        }
    }
}

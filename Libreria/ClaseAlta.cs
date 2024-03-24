namespace Libreria;

public class ClaseAlta : IEstado
{
    public void ControlarEstado(Familia familia)
    {
        // if (familia.Ingresos < 1000)
        // {
        //     familia.DefinirEstado(new ClaseBaja());
        // }
        // else if (familia.Ingresos >= 1000 && familia.Ingresos <= 5000)
        // {
        //     familia.DefinirEstado(new ClaseMedia());
        // }
        familia.DefinirEstado(SelecionarEstado.AsignarEstado(familia));
    }
    public string Describir()
    {
        return "Familia de clase alta";
    }
}

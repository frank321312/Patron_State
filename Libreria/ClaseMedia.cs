namespace Libreria;

public class ClaseMedia : IEstado
{
    public void ControlarEstado(Familia familia)
    {
        // if (familia.Ingresos < 1000)
        // {
        //     familia.DefinirEstado(new ClaseBaja());
        // }
        // else if (familia.Ingresos > 5000)
        // {
        //     familia.DefinirEstado(new ClaseAlta());
        // }
        familia.DefinirEstado(SelecionarEstado.AsignarEstado(familia));
    }
    public string Describir()
    {
        return "Familia de clase media";
    }
}

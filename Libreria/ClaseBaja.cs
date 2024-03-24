namespace Libreria;

public class ClaseBaja : IEstado
{
    public void ControlarEstado(Familia familia)
    {
        // if (familia.Ingresos >= 1000 && familia.Ingresos <= 5000)
        // {
        //     familia.DefinirEstado(new ClaseMedia());
        // }
        // else if (familia.Ingresos > 5000)
        // {
        //     familia.DefinirEstado(new ClaseAlta());
        // } 
        familia.DefinirEstado(SelecionarEstado.AsignarEstado(familia));
    }
    public string Describir()
    {
        return "Familia de clase baja";
    }
}

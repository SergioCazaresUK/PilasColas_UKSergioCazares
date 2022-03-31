using Arreglos;
using Listas;

/*Arreglos.Pilas pilas = new Arreglos.Pilas(10);
pilas.Agregar("cero");
pilas.Agregar("uno");
pilas.Agregar("dos");
pilas.Agregar("tres");
pilas.Agregar("cuatro");
pilas.Agregar("cinco");
Console.WriteLine(pilas.imprimir());
for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("--------------------------------");
        pilas.Eliminar();
        Console.WriteLine(pilas.imprimir());
    }
    catch (Exception ex) 
    {

        Console.WriteLine(ex.Message);
    }
    

}*/

Listas.Pilas Lpilas = new Listas.Pilas(10);
Lpilas.Agregar("cero");
Lpilas.Agregar("uno");
Lpilas.Agregar("dos");
Lpilas.Agregar("tres");
Lpilas.Agregar("cuatro");
Lpilas.Agregar("cinco");
Console.WriteLine(Lpilas.Imprimir());
for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("--------------------------------");
        Lpilas.Eliminar();
        Console.WriteLine(Lpilas.Imprimir());
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }


}
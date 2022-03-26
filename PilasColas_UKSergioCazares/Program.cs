using Arreglos;

Pilas pilas = new Pilas(10);
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

    }
    catch (Exception ex) 
    {

        Console.WriteLine(ex.Message);
    }
    Console.WriteLine("--------------------------------");

}
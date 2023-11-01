using EjercicioAbstraccion;

Libro miLibro = new Libro("Biblioteca del programador","Roger Gurdian", "Informativo", "Acantilado");
miLibro.Isbn = "0-7645-2641-3";
miLibro.Precio_unitario = 100;
miLibro.Precio_venta = 150;
miLibro.stock = 15;
//--------------------------------------------------------------------------------------------------------------
Libro miLibro2 = new Libro("Cien años de soledad", "Gabriel García Márquez", "Literario", "Bellas artes");
miLibro2.Isbn = "0-7645-2121-3";
miLibro2.Precio_unitario = 200;
miLibro2.Precio_venta = 230;
miLibro2.stock = 10;
/*
 */
Revista  miRevista = new Revista("Sociedad Futura", "Alejandro Guerrero", "Juvenil", "ParisMoled");
miRevista.Issn = "1026-0994";
miRevista.Precio_unitario = 300;
miRevista.Precio_venta = 325;
miRevista.stock = 11;
//--------------------------------------------------------------------------------------------------------------
Revista miRevista2 = new Revista("Impactus", "Mabel Robles", "Religiosa", "DiosBueno");
miRevista2.Issn = "1026-0224";
miRevista2.Precio_unitario = 180;
miRevista2.Precio_venta = 250;
miRevista2.stock = 21;


Console.WriteLine("Los datos de mis productos.");
Console.WriteLine(miLibro.titulo());
Console.WriteLine(miLibro.imprimirDatos());
Console.WriteLine(miLibro.imprimirCampos());
Console.WriteLine("");
Console.WriteLine(miLibro2.titulo());
Console.WriteLine(miLibro2.imprimirDatos());
Console.WriteLine(miLibro2.imprimirCampos());
Console.WriteLine("");
Console.WriteLine(miRevista.titulo());
Console.WriteLine(miRevista.imprimirDatos());
Console.WriteLine(miRevista.imprimirCampos());
Console.WriteLine("");
Console.WriteLine(miRevista2.titulo());
Console.WriteLine(miRevista2.imprimirDatos());
Console.WriteLine(miRevista2.imprimirCampos());



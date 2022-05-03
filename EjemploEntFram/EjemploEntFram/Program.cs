using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEntFram
{
     class Program
    {
        static void Main(string[] args)
        {
            using (BarDbEntities db = new BarDbEntities())
            {
                bool salir = false;


                while (!salir)
                {

                    try
                    {
                        int num = 0;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("***---------------------------------------**");
                        Console.WriteLine("           **Welcome to our Bar*            ");
                        Console.WriteLine("***---------------------------------------**");
                        Console.WriteLine("        Elige una de las opciones\n         ");
                        Console.WriteLine("        1. Insertar nuevo Producto          ");
                        Console.WriteLine("        2. Actualizar un Producto           ");
                        Console.WriteLine("        3. Eliminar un Producto             ");
                        Console.WriteLine("        4. Salir\n                          ");
                        Console.WriteLine("***---------------------------------------**");
                        num = Convert.ToInt32(Console.ReadLine());

                        switch (num)
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("-Has elegido Insertar nuevo Producto    ");
                                Console.WriteLine("");
                                Producto oProducto = new Producto();
                                Console.WriteLine("-Ingrese el Nombre : ");
                                oProducto.nomProd = Console.ReadLine();                              
                                Console.WriteLine("\nIngrese la descripcion : ");
                                oProducto.descripcion = Console.ReadLine();                                
                                Console.WriteLine("\n-Ingrese el precio :  ");
                                oProducto.precio = Convert.ToInt32(Console.ReadLine());                               
                                Console.WriteLine("\n-Ingrese la cantidad");
                                oProducto.cantidad = Convert.ToInt32(Console.ReadLine());                       
                                Console.WriteLine("\n-Ingrese el estado ");
                                oProducto.estado = Convert.ToInt32(Console.ReadLine());
                                

                                db.Producto.Add(oProducto);
                                db.SaveChanges();
                                Console.WriteLine();

                                break;

                            case 2:
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("-Has elegido Actualizar un Producto\n    ");
                                Console.WriteLine("");
                                Producto Producto = db.Producto.Find(1);
                                Console.WriteLine("\n-Ingrese el Nombre :  ");
                                Producto.nomProd = Console.ReadLine();
                                Console.WriteLine("\n-Ingrese la descripcion :  ");
                                Producto.descripcion = Console.ReadLine();
                                Console.WriteLine("\n-Ingrese el precio :  ");
                                Producto.precio = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n-Ingrese la cantidad");
                                Producto.cantidad = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n-Ingrese el estado ");
                                Producto.estado = Convert.ToInt32(Console.ReadLine());
                                db.Entry(Producto).State = System.Data.Entity.EntityState.Modified;
                                db.SaveChanges();
                                

                                break;

                            case 3:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n");
                                Producto producto = db.Producto.Find(12);
                                db.Producto.Remove(producto);
                                db.SaveChanges();
                                Console.ForegroundColor = ConsoleColor.Green;
                                


                                break;
                            case 4:
                                
                                salir = true;
                                break;
                           
                        }

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                

            }
           
        }
    }
    
}

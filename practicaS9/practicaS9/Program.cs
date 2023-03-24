using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace practicaS9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Programa ft = new Programa();
            ft.menus();
            Console.ReadKey();
        }

    }
}


class Enfermedad
{
    public string Nombre { get; set; }
    public string[] Medicamentos { get; set; }
}

class Medicamento
{
    public string Nombre { get; set; }
    public int Cantidad { get; set; }
    public string Tipo { get; set; }
    public DateTime FechaVencimiento { get; set; }
    public float Dosificacion { get; set; }
}

class Cliente
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
}

class Programa
{
    static Enfermedad[] enfermedades = new Enfermedad[] {
        new Enfermedad { Nombre = "Gripe", Medicamentos = new string[] {"Paracetamol", "Ibuprofeno", "Vitamina C"} },
        new Enfermedad { Nombre = "Dolor de cabeza", Medicamentos = new string[] {"Aspirina", "Paracetamol", "Ibuprofeno"} },
        new Enfermedad { Nombre = "Dolor de estómago", Medicamentos = new string[] {"Omeprazol", "Ranitidina", "Bismutol"} },
        new Enfermedad { Nombre = "Dolor muscular", Medicamentos = new string[] {"Paracetamol", "Ibuprofeno", "Diclofenaco"} }
    };

    static Medicamento[] medicamentos = new Medicamento[] {
        new Medicamento { Nombre = "ibuprofeno", Tipo = "pastilla", Dosificacion = 500, Cantidad = 20, FechaVencimiento = new DateTime(2024, 12, 31) },
        new Medicamento { Nombre = "paracetamol", Tipo = "pastilla", Dosificacion = 400, Cantidad = 30, FechaVencimiento = new DateTime(2025, 6, 30) },
        new Medicamento { Nombre = "vitamina c", Tipo = "jarabe", Dosificacion = 1000, Cantidad = 10, FechaVencimiento = new DateTime(2023, 9, 30) },
        new Medicamento { Nombre = "aspirina", Tipo = "pastilla", Dosificacion = 100, Cantidad = 25, FechaVencimiento = new DateTime(2024, 3, 31) },
        new Medicamento { Nombre = "omeprazol", Tipo = "pastilla", Dosificacion = 20, Cantidad = 15, FechaVencimiento = new DateTime(2025, 1, 31) },
        new Medicamento { Nombre = "ranitidina", Tipo = "pastilla", Dosificacion = 150, Cantidad = 10, FechaVencimiento = new DateTime(2024, 8, 31) },
        new Medicamento { Nombre = "bismutol", Tipo = "pastilla", Dosificacion = 200, Cantidad = 5, FechaVencimiento = new DateTime(2023, 12, 31) },
        new Medicamento { Nombre = "diclofenaco", Tipo = "inyeccion", Dosificacion = 75, Cantidad = 8, FechaVencimiento = new DateTime(2024, 2, 28) }
    };
    public void mostrar()
    {
        foreach (var date in enfermedades)
        {
            Console.WriteLine($"ENFERMEDAD:{date.Nombre}\nMEDICAMENTOS:\n{date.Medicamentos[0]}\n{date.Medicamentos[1]}\n{date.Medicamentos[2]}\n-------------------------------------------------------\n\n");

        }
        menus();

    }
    public void vender()
    {
        
        foreach (var item in medicamentos)
        {
            
            Console.WriteLine($"Nombre:{item.Nombre}, Tipo: {item.Tipo}, Dosificacion: {item.Dosificacion} Gramos, Cantidad: {item.Cantidad} , Fecha de vencimiento: {item.FechaVencimiento}.\n");

        }
        Console.WriteLine("¿INGRESA EL NOMBRE DEL MEDICAMENTO QUE QUIERES VENDER....?");
        string data = Console.ReadLine();

        switch (data)
        {
            case "paracetamol":
                foreach (var item in medicamentos)
                {
                    if (item.Nombre == data)
                    {
                        Console.WriteLine($"¿quieres vender el siguiente medicamento?\n");
                        Console.WriteLine($"-Nombre:{item.Nombre}, Tipo: {item.Tipo}, Dosificacion: {item.Dosificacion} Gramos, Cantidad: {item.Cantidad} , Fecha de vencimiento: {item.FechaVencimiento}.-\n----Presiona 1 para confirmar,----\n----presiona 2 para cancerlar----\n");
                        int vb = int.Parse(Console.ReadLine());
                        switch (vb)
                        {
                            case 1:
                                Console.WriteLine($"se vendio el siguiente medicamento\n-Nombre:{item.Nombre}, Tipo: {item.Tipo}, Dosificacion: {item.Dosificacion} Gramos, Cantidad: {item.Cantidad} , Fecha de vencimiento: {item.FechaVencimiento}.-");
                                Console.WriteLine("\npresione ENTER para regresar al menu inicial.");
                                menus();
                                break;
                            case 2:
                                Console.WriteLine("su venta fue cancelada, rediriguiendo al menu iniciar...");
                                menus();
                                break;
                            default:
                                break;
                        }

                    }
                 
                }
                break;

            case "ibuprofeno":
                foreach (var item in medicamentos)
                {
                    if (item.Nombre == data)
                    {
                        Console.WriteLine($"¿quieres vender el siguiente medicamento?\n");
                        Console.WriteLine($"-Nombre:{item.Nombre}, Tipo: {item.Tipo}, Dosificacion: {item.Dosificacion} Gramos, Cantidad: {item.Cantidad} , Fecha de vencimiento: {item.FechaVencimiento}.-\n----Presiona 1 para confirmar,----\n----presiona 2 para cancerlar----\n");
                        int vb = int.Parse(Console.ReadLine());
                        switch (vb)
                        {
                            case 1:
                                Console.WriteLine($"se vendio el siguiente medicamento\n-Nombre:{item.Nombre}, Tipo: {item.Tipo}, Dosificacion: {item.Dosificacion} Gramos, Cantidad: {item.Cantidad} , Fecha de vencimiento: {item.FechaVencimiento}.-");
                                Console.WriteLine("\npresione ENTER para regresar al menu inicial.");
                                menus();
                                break;
                            case 2:
                                Console.WriteLine("su venta fue cancelada, rediriguiendo al menu iniciar...");
                                menus();
                                break;
                            default:
                                break;
                        }

                    }
                    break;
                }
                break;
                
            case "vitamina c":
                foreach (var item in medicamentos)
                {
                    if (item.Nombre == data)
                    {
                        Console.WriteLine($"¿quieres vender el siguiente medicamento?\n");
                        Console.WriteLine($"-Nombre:{item.Nombre}, Tipo: {item.Tipo}, Dosificacion: {item.Dosificacion} Gramos, Cantidad: {item.Cantidad} , Fecha de vencimiento: {item.FechaVencimiento}.-\n----Presiona 1 para confirmar,----\n----presiona 2 para cancerlar----\n");
                        int vb = int.Parse(Console.ReadLine());
                        switch (vb)
                        {
                            case 1:
                                Console.WriteLine($"se vendio el siguiente medicamento\n-Nombre:{item.Nombre}, Tipo: {item.Tipo}, Dosificacion: {item.Dosificacion} Gramos, Cantidad: {item.Cantidad} , Fecha de vencimiento: {item.FechaVencimiento}.-");
                                Console.WriteLine("\npresione ENTER para regresar al menu inicial.");
                                menus();
                                break;
                            case 2:
                                Console.WriteLine("su venta fue cancelada, rediriguiendo al menu iniciar...");
                                menus();
                                break;
                            default:
                                break;
                        }

                    }
                }
                 break;
            case "aspirina":
                foreach (var item in medicamentos)
                {
                    if (item.Nombre == data)
                    {
                        Console.WriteLine($"¿quieres vender el siguiente medicamento?\n");
                        Console.WriteLine($"-Nombre:{item.Nombre}, Tipo: {item.Tipo}, Dosificacion: {item.Dosificacion} Gramos, Cantidad: {item.Cantidad} , Fecha de vencimiento: {item.FechaVencimiento}.-\n----Presiona 1 para confirmar,----\n----presiona 2 para cancerlar----\n");
                        int vb = int.Parse(Console.ReadLine());
                        switch (vb)
                        {
                            case 1:
                                Console.WriteLine($"se vendio el siguiente medicamento\n-Nombre:{item.Nombre}, Tipo: {item.Tipo}, Dosificacion: {item.Dosificacion} Gramos, Cantidad: {item.Cantidad} , Fecha de vencimiento: {item.FechaVencimiento}.-");
                                Console.WriteLine("\npresione ENTER para regresar al menu inicial.");
                                menus();
                                break;
                            case 2:
                                Console.WriteLine("su venta fue cancelada, rediriguiendo al menu iniciar...");
                                menus();
                                break;
                            default:
                                break;
                        }

                    }
                }
                break;
            case "omeprazol":
                foreach (var item in medicamentos)
                {
                    if (item.Nombre == data)
                    {
                        Console.WriteLine($"¿quieres vender el siguiente medicamento?\n");
                        Console.WriteLine($"-Nombre:{item.Nombre}, Tipo: {item.Tipo}, Dosificacion: {item.Dosificacion} Gramos, Cantidad: {item.Cantidad} , Fecha de vencimiento: {item.FechaVencimiento}.-\n----Presiona 1 para confirmar,----\n----presiona 2 para cancerlar----\n");
                        int vb = int.Parse(Console.ReadLine());
                        switch (vb)
                        {
                            case 1:
                                Console.WriteLine($"se vendio el siguiente medicamento\n-Nombre:{item.Nombre}, Tipo: {item.Tipo}, Dosificacion: {item.Dosificacion} Gramos, Cantidad: {item.Cantidad} , Fecha de vencimiento: {item.FechaVencimiento}.-");
                                Console.WriteLine("\npresione ENTER para regresar al menu inicial.");
                                menus();
                                break;
                            case 2:
                                Console.WriteLine("su venta fue cancelada, rediriguiendo al menu iniciar...");
                                menus();
                                break;
                            default:
                                break;
                        }

                    }
                }
                break;
            case "ranitidina":
                foreach (var item in medicamentos)
                {
                    if (item.Nombre == data)
                    {
                        Console.WriteLine($"¿quieres vender el siguiente medicamento?\n");
                        Console.WriteLine($"-Nombre:{item.Nombre}, Tipo: {item.Tipo}, Dosificacion: {item.Dosificacion} Gramos, Cantidad: {item.Cantidad} , Fecha de vencimiento: {item.FechaVencimiento}.-\n----Presiona 1 para confirmar,----\n----presiona 2 para cancerlar----\n");
                        int vb = int.Parse(Console.ReadLine());
                        switch (vb)
                        {
                            case 1:
                                Console.WriteLine($"se vendio el siguiente medicamento\n-Nombre:{item.Nombre}, Tipo: {item.Tipo}, Dosificacion: {item.Dosificacion} Gramos, Cantidad: {item.Cantidad} , Fecha de vencimiento: {item.FechaVencimiento}.-");
                                Console.WriteLine("\npresione ENTER para regresar al menu inicial.");
                                menus();
                                break;
                            case 2:
                                Console.WriteLine("su venta fue cancelada, rediriguiendo al menu iniciar...");
                                menus();
                                break;
                            default:
                                break;
                        }

                    }
                }
                break;
            case "bismutol":
                foreach (var item in medicamentos)
                {
                    if (item.Nombre == data)
                    {
                        Console.WriteLine($"¿quieres vender el siguiente medicamento?\n");
                        Console.WriteLine($"-Nombre:{item.Nombre}, Tipo: {item.Tipo}, Dosificacion: {item.Dosificacion} Gramos, Cantidad: {item.Cantidad} , Fecha de vencimiento: {item.FechaVencimiento}.-\n----Presiona 1 para confirmar,----\n----presiona 2 para cancerlar----\n");
                        int vb = int.Parse(Console.ReadLine());
                        switch (vb)
                        {
                            case 1:
                                Console.WriteLine($"se vendio el siguiente medicamento\n-Nombre:{item.Nombre}, Tipo: {item.Tipo}, Dosificacion: {item.Dosificacion} Gramos, Cantidad: {item.Cantidad} , Fecha de vencimiento: {item.FechaVencimiento}.-");
                                Console.WriteLine("\npresione ENTER para regresar al menu inicial.");
                                menus();
                                break;
                            case 2:
                                Console.WriteLine("su venta fue cancelada, rediriguiendo al menu iniciar...");
                                menus();
                                break;
                            default:
                                break;
                        }

                    }

                }
                break;
            case "diclofenaco":
                foreach (var item in medicamentos)
                {
                    if (item.Nombre == data)
                    {
                        Console.WriteLine($"¿quieres vender el siguiente medicamento?\n");
                        Console.WriteLine($"-Nombre:{item.Nombre}, Tipo: {item.Tipo}, Dosificacion: {item.Dosificacion} Gramos, Cantidad: {item.Cantidad} , Fecha de vencimiento: {item.FechaVencimiento}.-\n----Presiona 1 para confirmar,----\n----presiona 2 para cancerlar----\n");
                        int vb = int.Parse(Console.ReadLine());
                        switch (vb)
                        {
                            case 1:
                                Console.WriteLine($"se vendio el siguiente medicamento\n-Nombre:{item.Nombre}, Tipo: {item.Tipo}, Dosificacion: {item.Dosificacion} Gramos, Cantidad: {item.Cantidad} , Fecha de vencimiento: {item.FechaVencimiento}.-");
                                Console.WriteLine("\npresione ENTER para regresar al menu inicial.");
                                menus();
                                break;
                            case 2:
                                Console.WriteLine("su venta fue cancelada, rediriguiendo al menu iniciar...");
                                menus();
                                break;
                            default:
                                break;
                        }

                    }

                }
                break;
            default:
                Console.WriteLine("esta opcion no se encuentra disponible, digite una opcion dentro de los rangos sugeridos.\n\n------------------------------------------------------\n");
                vender();

                break;
        }
        
        
    }
    public void menus()
    {
        
        Console.WriteLine("-----------MENU-----------\n" +
            "Bienvenidos a la farmacia el bungalito\n¿elija una opcion?\n" +
            "1)Mostrar el catalogo de segun las enfermedades.\n2)Realizar una venta.\n3)salir.");
        int vari = int.Parse(Console.ReadLine());
        switch (vari)
        {
            case 1:
                mostrar();
                break;
            case 2:
                vender();
                break;
            case 3:
                salir();
                break;

            default:
                Console.WriteLine("esta opcion no existe");
                break;
        }
    }
    public void salir()
    {

        Environment.Exit(0);

    }
}


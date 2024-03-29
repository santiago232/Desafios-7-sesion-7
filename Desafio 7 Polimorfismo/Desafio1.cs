using System;
using System.Collections.Generic;
using System.IO;

class Auto
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }
    protected List<string> reparaciones = new List<string>();

    public void Reparar(string descripcion)
    {
        reparaciones.Add(descripcion);
    }

    public void HistoriaDeReparaciones()
    {
        Console.WriteLine("Historia de reparaciones:");
        foreach (string reparacion in reparaciones)
        {
            Console.WriteLine(reparacion);
        }
    }
}

class BMW : Auto
{
    private const string NOMBRE_ARCHIVO = "reparaciones.txt";

    public new void Reparar(string descripcion)
    {
        base.Reparar(descripcion);
        File.AppendAllText(NOMBRE_ARCHIVO, $"{DateTime.Now}: {descripcion}{Environment.NewLine}");
    }

    public new void HistoriaDeReparaciones()
    {
        Console.WriteLine("Historia de reparaciones (desde archivo):");
        if (File.Exists(NOMBRE_ARCHIVO))
        {
            foreach (string linea in File.ReadAllLines(NOMBRE_ARCHIVO))
            {
                Console.WriteLine(linea);
            }
        }
        else
        {
            Console.WriteLine("No se encontró el archivo de reparaciones.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BMW miAuto = new BMW
        {
            Marca = "BMW",
            Modelo = "Serie 3",
            Año = 2018
        };

        miAuto.Reparar("Cambio de aceite");
        miAuto.Reparar("Reparación de frenos");
        miAuto.Reparar("Rotación de llantas");

        miAuto.HistoriaDeReparaciones();
    }
}
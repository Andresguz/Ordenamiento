using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.SceneManagement;
public class botones : MonoBehaviour
{
    TextReader leerArchivo;
    TextWriter Archivo;
    int nivel;

    public GameController controller;
    public void IniciaJuego()
    {
        leerArchivo= new StreamReader(@"C:\User\" + Environment.UserName + @"\Documents\MegaMan\Save\save.txt");
        nivel = int.Parse(leerArchivo.ReadLine());
        int monedas = int.Parse(leerArchivo.ReadLine());
        int vidas = int.Parse(leerArchivo.ReadLine());
        controller.datosNivvel(nivel, monedas, vidas);

        leerArchivo.Close();

        if (nivel !=1)
        {
            SceneManager.LoadScene(3);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }    

    public void ContinuarPartida()
    {
        nivel = controller.Nivel();
        SceneManager.LoadScene(nivel);
    }
    public void NuevaPartida()
    {
        Archivo = new StreamWriter(@"C:\User\" + Environment.UserName + @"\Documents\MegaMan\Save\save.txt");
        Archivo.WriteLine(1);
        Archivo.WriteLine(0);
        Archivo.WriteLine(3);
        Archivo.Close();

        leerArchivo = new StreamReader(@"C:\User\" + Environment.UserName + @"\Documents\MegaMan\Save\save.txt");
        nivel = int.Parse(leerArchivo.ReadLine());
        int monedas = int.Parse(leerArchivo.ReadLine());
        int vidas = int.Parse(leerArchivo.ReadLine());
        controller.datosNivvel(nivel, monedas, vidas);

        leerArchivo.Close();
        SceneManager.LoadScene(1);
    }
}

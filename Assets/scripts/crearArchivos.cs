using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
public class crearArchivos : MonoBehaviour
{
    TextWriter archivo;
    string direccion;

    void Start()
    {
        direccion = @"C:\User\" + Environment.UserName + @"\Documents\MegaMan\Save";
        if (Directory.Exists(direccion)==false)
        {
            DirectoryInfo di = Directory.CreateDirectory(direccion);
            archivo = new StreamWriter(@"C:\User\" + Environment.UserName + @"\Documents\MegaMan\Save\save.txt");
            archivo.WriteLine(1);//nivel
            archivo.WriteLine(0);//monedas
            archivo.WriteLine(3);//vidas

            archivo.Close();

        }
    }

}

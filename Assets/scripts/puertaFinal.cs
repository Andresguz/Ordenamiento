using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puertaFinal : MonoBehaviour
{
    public vida vidas;
    public MOVEMENT llave;
    TextWriter archivo;
    TextReader archivolee;
    int nivel;
    public GameController controller;
    void Start()
    {
        archivolee = new StreamReader(@"C:\User\" + Environment.UserName + @"\Documents\MegaMan\Save\save.txt");
        nivel = int.Parse(archivolee.ReadLine());
        nivel += 1;
        archivolee.Close();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="Player")
        {
            if (llave.llaveActiva)
            {
                archivo = new StreamWriter(@"C:\User\" + Environment.UserName + @"\Documents\MegaMan\Save\save.txt");
                archivo.WriteLine(nivel);
                archivo.WriteLine(vidas.coin);
                archivo.WriteLine(vidas.vidas);
               
                archivo.Close();
                controller.datosNivvel(nivel, vidas.vidas, vidas.coin);
                SceneManager.LoadScene(nivel);

            }
        }
    }
 
}

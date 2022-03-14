using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    static int cantidadMoneda = 0;
    static int cantidadVidas = 3;
    static int nivelJuego = 1;
  
    public void datosNivvel(int nivel, int monedas, int vidas)
    {
        nivelJuego = nivel;
        cantidadMoneda = monedas;
        cantidadVidas = vidas;
    }
    public int Nivel()
    {
        return nivelJuego;
    }
    public int Vidas()
    {
        return cantidadVidas;
    }
    public int Monedas()
    {
        return cantidadMoneda;
    }
    
}

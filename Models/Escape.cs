
namespace TP5_SalaDeEscape_Nieto.Models;
using System.Collections.Generic;

public static class Escape
{
    //private static string[] incogitasSalas = new string [5];
    private static List<string> incognitasSalas = new List<string> ();
    private static int estadoJuego = 1;
    private static void InicializarJuego(){
        //Inicializa el juego con el array de incógnitas correctas ??
        //incognitasSalas =   ["3", "RJP", "331", "Smelly Cat - Ken Adams - Janice - Joey - Joey - Ursula", "Monica"];
        incognitasSalas.Add("3");
        incognitasSalas.Add("RJP");
        incognitasSalas.Add("331");
        incognitasSalas.Add("SMELLY CAT - KEN ADAMS - JANICE - JOEY - JOEY - URSULA");
        incognitasSalas.Add("MONICA");

    }
    public static int GetEstadoJuego(){
        return estadoJuego;
    }
    public static bool ResolverSala(int Sala, string Incognita){
        bool ret = false;
        if(incognitasSalas == null){
            InicializarJuego();
        }
        if(Sala == estadoJuego && Incognita.Trim().ToUpper().Equals(incognitasSalas[estadoJuego-1])){ //IncognitasSalas == 0 --> Pq?
            ret = true;
            estadoJuego++;
        }
        return ret;
        //Tener en cuenta que si el array de incognitas tiene 0 elementos debe llamar a InicializarJuego (como ocurrio con el TP anterior --> que TP?)  ??
    }
}


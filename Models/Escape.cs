
namespace TP5_SalaDeEscape_Nieto.Models;


public static class Escape
{
    private static string[] incogitasSalas = new string [5];
    private static int estadoJuego = 1;
    private static void InicializarJuego(){
        //Inicializa el juego con el array de incógnitas correctas ??
        incognitasSalas =   {"3", "RJP", "331", "Smelly Cat - Ken Adams - Janice - Joey - Joey - Ursula", "Monica"};
    }
    public static int GetEstadoJuego(){
        return estadoJuego;
    }
    public static bool ResolverSala(int Sala, string Incognita){
        bool ret = false;
        if(Sala == estadoJuego && Incognita == incogitasSalas[estadoJuego-1]){
            ret = true;
            estadoJuego++;
        }
        return ret;
        //Tener en cuenta que si el array de incognitas tiene 0 elementos debe llamar a InicializarJuego (como ocurrio con el TP anterior --> que TP?)  ??
    }
}


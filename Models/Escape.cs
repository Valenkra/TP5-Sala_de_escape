class Escape 
{
    private static string[] incognitasSalas= new string[10] 
    {
        "4", "XII", "2122191524", "1419914", "ABCJLF",
        "4", "XII", "2122191524", "1419914", "ABCJLF"
    };
    private static int estadoJuego = 0;
    private static void InicializarJuego(){
        estadoJuego = 1;
    }

    public static int GetEstadoJuego(){
        if(estadoJuego == 0) {
            InicializarJuego();
        }
        return estadoJuego;
    }
    public static bool ResolverSala(int Sala, string Incognita){
        string temp = Convert.ToString(Incognita).ToUpper();
        if(incognitasSalas[Sala-1] == temp){
            estadoJuego++;
            return true;
        } else {
            return false;
        }
    } 
}
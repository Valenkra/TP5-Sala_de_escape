class Escape 
{
    private static string[] incognitasSalas= new string[4] 
    {
        "4", "XII", "2122191524", "1419914"
    };
    private static int estadoJuego = 0;
    public static int GetEstadoJuego(){
        if(estadoJuego == 0) {
            estadoJuego = 1;
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
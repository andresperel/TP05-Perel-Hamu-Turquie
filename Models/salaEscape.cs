using Newtonsoft.Json;
public class salaEscape
{
    [JsonProperty]
    public List<string> rtasCorrectas;
    [JsonProperty]
    private List<string> pista;
    [JsonProperty]
    public int nroSala;
    public void inicializarJuego()
    {
        rtasCorrectas = new List<string>();
        pista = new List<string>();
        nroSala=1;
        rtasCorrectas.Add("a");
        pista.Add("“No tengo forma, pero marco el ritmo de tu encierro. Descíframe antes de que yo me transforme.”");
        rtasCorrectas.Add("espejo");
        pista.Add("“No hablo, pero digo la verdad, no miento, pero te muestro lo que tú me das.”");
        rtasCorrectas.Add("a");
        pista.Add("Debes encontrar una herramienta que lo ayude a escapar");
        rtasCorrectas.Add("32");
        pista.Add("El número del cable a cortar debe estar representado en hexadecimal");
        rtasCorrectas.Add("salir");
        pista.Add("No te olvides que homero no es muy inteligente! La hoja puede no estar bien acomodada...");
        rtasCorrectas.Add("final");
        pista.Add("No muestro");
        rtasCorrectas.Add("final");
        pista.Add("No muestro");
        
    }
    public string sacarHora(){
        return DateTime.Now.ToString("HHmm");
    }
    public void comprobarClave(string claveProbada)
    {
        if(rtasCorrectas[nroSala-1] == claveProbada){
            nroSala++;
        }
    }

    public string devolverPista()
    {
        return pista[nroSala-1];
    }
}
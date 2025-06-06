using Newtonsoft.Json;
public class salaEscape
{
    [JsonProperty]
    public List<string> rtasCorrectas;
    [JsonProperty]
    private List<string> pista;
    [JsonProperty]
    public int nroSala;

    public string ObjectToString<T>(T? obj)
    {
        return JsonConvert.SerializeObject(obj);
    }
    public T? StringToobject<T>(string txt)
    {
        if (string.IsNullOrEmpty(txt))
            return default;
        else
            return JsonConvert.DeserializeObject<T>(txt);
    }

    public void inicializarJuego()
    {
        rtasCorrectas = new List<string>();
        pista = new List<string>();
        nroSala=1;
        string clave1 = DateTime.Now.ToString("HHmm");
        rtasCorrectas.Add("3");
        pista.Add("Adivinanza: “No tengo forma, pero marcó el ritmo de tu encierro. Descíframe antes de que yo me transforme.”");
        rtasCorrectas.Add("espejo");
        pista.Add("Adivinanza: No hablo, pero digo la verdad, no miento, pero te muestro lo que tú me das.");
        rtasCorrectas.Add("a");
        pista.Add("");
        rtasCorrectas.Add("a");
        pista.Add("Los cables en la izquierda tienen un número en binario y lo tienen que pasar a hexadecimal, ese número estará en uno de los cables a la derecha");
        rtasCorrectas.Add("a");
        pista.Add("~/imagenes/fotoPista5");

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
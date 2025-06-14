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
        rtasCorrectas.Add("martin lousteau");
        pista.Add("“No tengo forma, pero marcó el ritmo de tu encierro. Descíframe antes de que yo me transforme.”");
        rtasCorrectas.Add("espejo");
        pista.Add("“No hablo, pero digo la verdad, no miento, pero te muestro lo que tú me das.”");
        rtasCorrectas.Add("a");
        pista.Add("Debes encontrar un alicate");
        rtasCorrectas.Add("a");
        pista.Add("Los cables en la izquierda tienen números en binario y lo tienen que pasar a hexadecimal, el cable que coincida es el que deberán tocar.");
        rtasCorrectas.Add("a");
        pista.Add("La 1 debes ir a la izquierda.");

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
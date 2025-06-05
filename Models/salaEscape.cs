using Newtonsoft.Json;
public static class salaEscape
{
    [JsonProperty]
    private static Dictionary<int, string> rtasCorrectas;
    [JsonProperty]
    private static Dictionary<int, string> pista;

    public static string ObjectToString<T>(T? obj)
    {
        return JsonConvert.SerializeObject(obj);
    }
    public static T? StringToobject<T>(string txt)
    {
        if (string.IsNullOrEmpty(txt))
            return default;
        else
            return JsonConvert.DeserializeObject<T>(txt);
    }

    public static void inicializarJuego()
    {
        rtasCorrectas = new Dictionary<int, string>();
        pista = new Dictionary<int, string>();
        string clave1 = DateTime.Now.ToString("HHmm");
        rtasCorrectas.Add(1, clave1);
        pista.Add(1, "Su celda está cerrada con un candado digital que se abre con una clave. ¡Cuidado! La clave no es siempre igual. Adivinanza: ““No tengo forma, pero marcó el ritmo de tu encierro. Descíframe antes de que yo me transforme.”");
        rtasCorrectas.Add(2, "espejo");
        pista.Add(2, "¡La celda ya está abierta! Pero hay muchos guardias y la luz está prendida, necesitamos apagarla. Adivinanza: No hablo, pero digo la verdad, no miento, pero te muestro lo que tú me das.");
        rtasCorrectas.Add(3,"a");
        pista.Add(3,"~/imagenes/fotoPista3");
        rtasCorrectas.Add(4,"a");
        pista.Add(4, "¡Homero salió de la celda! Hay muchos guardias en el pasillo, ¿Qué podemos hacer para que no nos vean? ¡Tendrás que cortar el cable que concuerde con el primero para cortar la luz!");
        rtasCorrectas.Add(5,"a");
        pista.Add(5, "~/imagenes/fotoPista5");

    }
    public static bool comprobarClave(string claveProbada, int sala)
    {
        return rtasCorrectas[sala] == claveProbada;
    }

    public static string devolverPista(int sala)
    {
        return pista[sala];
    }
}
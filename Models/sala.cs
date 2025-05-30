using Newtonsoft.Json;
public static class sala
{
    [JsonProperty]
    public static string clave { get; private set; }
    [JsonProperty]
    public static string pista { get; private set; }

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

    public static bool comprobarClave(string claveProbada){
        return clave==claveProbada;
    }
}
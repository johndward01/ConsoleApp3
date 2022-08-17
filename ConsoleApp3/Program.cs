

using Newtonsoft.Json;

var client = new HttpClient();
var root = new Root();
var url = "https://airlabs.co/api/v9/airlines?&api_key=d6be5dd7-cf0b-44f6-a883-3d1b8a475ae2";
var response = client.GetStringAsync(url).Result;
root = JsonConvert.DeserializeObject<Root>(response);

foreach (var item in root.response)
{
    Console.WriteLine(item.name);
    Console.WriteLine();
}

public class Key
{
    public int id { get; set; }
    public string api_key { get; set; }
    public string type { get; set; }
    public string expired { get; set; }
    public string registered { get; set; }
    public int limits_by_hour { get; set; }
    public int limits_by_minute { get; set; }
    public int limits_by_month { get; set; }
    public int limits_total { get; set; }
}

public class Params
{
    public string lang { get; set; }
}

public class Geo
{
    public string country_code { get; set; }
    public string country { get; set; }
    public string continent { get; set; }
    public string city { get; set; }
    public double lat { get; set; }
    public double lng { get; set; }
    public string timezone { get; set; }
}

public class Connection
{
    public string type { get; set; }
    public int isp_code { get; set; }
    public string isp_name { get; set; }
}

public class Device
{
}

public class Agent
{
}

public class Karma
{
    public string is_blocked { get; set; }
    public string is_crawler { get; set; }
    public string is_bot { get; set; }
    public string is_friend { get; set; }
    public string is_regular { get; set; }
}

public class Client
{
    public string ip { get; set; }
    public Geo geo { get; set; }
    public Connection connection { get; set; }
    public Device device { get; set; }
    public Agent agent { get; set; }
    public Karma karma { get; set; }
}

public class Request
{
    public string lang { get; set; }
    public string currency { get; set; }
    public int time { get; set; }
    public string id { get; set; }
    public string server { get; set; }
    public string host { get; set; }
    public int pid { get; set; }
    public Key key { get; set; }
    public Params @params { get; set; }
    public int version { get; set; }
    public string method { get; set; }
    public Client client { get; set; }
}

public class ResponseItem
{
    public string icao_code { get; set; }
    public string iata_code { get; set; }
    public string name { get; set; }
}

public class Root
{
    public Request request { get; set; }
    public List<ResponseItem> response { get; set; }
    public string terms { get; set; }
}

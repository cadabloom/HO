// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System;
using System.Text.Json.Nodes;
using DataIngestApp.OOP;
using DataIngestApp.OOP.Processors;

//Procedural
Console.WriteLine("####Procedural####");
Console.WriteLine("Weather Result");
LoadAndProcess("Data\\weather.json", "Dy", "MxT", "MnT");
Console.WriteLine("Scores Result");
LoadAndProcess("Data\\scores.json", "team", "F", "A");

Console.WriteLine();

//OOP
Console.WriteLine("####OOP####");
var weatherProcessor = new WeatherMinSpreadProcessor();
var scoreProcessor = new ScoreMinSpreadProcessor();
var weatherData = new DataContainer<WeatherData>("Data\\weather.json");
var scoreData = new DataContainer<ScoreData>("Data\\scores.json");
var weatherResult = weatherData.Process(weatherProcessor);
var scoreResult = scoreData.Process(scoreProcessor);

Console.WriteLine("Weather Result");
weatherResult.PrintOutput();
Console.WriteLine("Scores Result");
scoreResult.PrintOutput();


public partial class Program
{
    public static void LoadAndProcess(string path, string idKey, string minuendKey, string subtrahendKey)
    {
        using (StreamReader r = new StreamReader(path))
        {
            string json = r.ReadToEnd();
            var list = JsonSerializer.Deserialize<List<JsonObject>>(json);
            var result = Process(list, idKey, minuendKey, subtrahendKey);
            Console.WriteLine(result);
        }
    }

    static Tuple<string, int, int, int> Process(List<JsonObject>? list, string idKey, string minuendKey, string subtrahendKey)
    {
        Tuple<string, int, int, int> tuple = new Tuple<string, int, int, int>(string.Empty, 0, 0, int.MaxValue);

        foreach (var child in list)
        {
            var spread = Math.Abs(child[minuendKey]!.GetValue<int>() - child[subtrahendKey]!.GetValue<int>());
            if (spread < tuple.Item4)
            {
                tuple = new Tuple<string, int, int, int>(child[idKey]!.ToString(), child[minuendKey]!.GetValue<int>(), child[subtrahendKey]!.GetValue<int>(), spread);
            }
        }

        return tuple;
    }


}


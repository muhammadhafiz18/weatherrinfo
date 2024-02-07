using weatherrinfo.Models;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Net.Http;

namespace weatherrinfo
{
    public class Getfromserver
    {
        static async Task Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("http://api.weatherapi.com/v1/current.json?key=yourtokenhereplease!!!q=Tashkent");

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Body result = JsonSerializer.Deserialize<Body>(content,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true })!;
                    Console.WriteLine($"Temp: {result.Current.FellslikeC}");

                }
                else
                {
                    Console.WriteLine($"error: => {response.StatusCode}");
                }

            }
        }
    }
}
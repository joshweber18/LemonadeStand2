using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public string todayWeather;
        public string weatherCondition;
        public int temperatureCondition;
        public List<string> weatherOptions = new List<string>();
        // public Dictionary<string, string> weatherTemperatureOptions = new Dictionary<string, string>();


        public Weather()
        {
            weatherOptions.Add("Rainy");
            weatherOptions.Add("Partially Sunny");
            weatherOptions.Add("Hot");
            weatherOptions.Add("Overcast");
            todayWeather = ChooseWeather();
        }

        public string ChooseWeather()
        {
            Random r = new Random();
            int randomNumber = r.Next(weatherOptions.Count);

            weatherCondition = weatherOptions[r.Next(0, weatherOptions.Count)];
            switch (weatherCondition)
            {
                case "Rainy":
                    temperatureCondition = r.Next(65, 75);
                    break;
                case "Sunny":
                    temperatureCondition = r.Next(75, 90);
                    break;
                case "Foggy":
                    temperatureCondition = r.Next(55, 65);
                    break;
                case "Overcast":
                    temperatureCondition = r.Next(40, 55);
                    break;
            }
            return weatherCondition;
        }
            


        public void DisplayWeather()
        {
            Console.WriteLine("Temperature: " + temperatureCondition + " ");
            Console.WriteLine("Weather: " + weatherCondition + " ");
        }
    }     
}

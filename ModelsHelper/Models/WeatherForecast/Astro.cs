﻿namespace ModelsHelper.Models.WeatherForecast
{
    public class Astro
    {
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public string moonrise { get; set; }
        public string moonset { get; set; }
        public string moon_phase { get; set; }
        public int moon_illumination { get; set; }
        public int is_moon_up { get; set; }
        public int is_sun_up { get; set; }


        public override string ToString()
        {
            return $"Sunrise: {sunrise}, Sunset: {sunset}, Moon Phase: {moon_phase}";
        }
    }

}

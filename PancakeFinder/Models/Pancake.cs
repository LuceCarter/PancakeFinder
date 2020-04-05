using System;
using System.Globalization;
using System.Text.Json;


namespace PancakeFinder.Models
{
    public partial class Pancake
    {        
        public string Name { get; set; }
        
        public string Origin { get; set; }
        
        public string Description { get; set; }
       
        public Uri ImageUrl { get; set; }
    }

    public partial class Pancake
    {
        public static Pancake[] FromJson(string json) => JsonSerializer.Deserialize<Pancake[]>(json);
    }

    public static class Serialize
    {
        public static string ToJson(this Pancake[] self) => JsonSerializer.Serialize(self);
    }

 }
using System;
using System.Globalization;
using System.Text.Json;


namespace PancakeFinder.Models
{
    public partial class Pancake
    {        
        public string name { get; set; }
        
        public string origin { get; set; }
        
        public string description { get; set; }
       
        public Uri imageUrl { get; set; }
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
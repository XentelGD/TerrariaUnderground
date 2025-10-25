using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class Sprites
    {
        public static Dictionary<string, Sprite> Registry = new Dictionary<string, Sprite>();
        
        public static void RegisterAll()
        {
            Registry.Add("Dirt", Resources.Load<Sprite>("Sprites/Environment/Blocks/dirt"));
        }

        public static Sprite GetSprite(string name)
        {
            return Registry[name];
        }
    }
}
using System.Collections.Generic;
using Environment;
using UnityEngine;

namespace Data
{
    public class Items
    {
        public static Dictionary<string, Item> Registry = new Dictionary<string, Item>();
        
        public static Item Dirt = new Item("dirt")
            .Set("MainSprite", Sprites.GetSprite("Dirt"));
        
        public static void RegisterAll()
        {
            Registry.Add("dirt", Dirt);
        }
        
        public static Item GetItem(string name)
        {
            return Registry[name];
        }
    }
}
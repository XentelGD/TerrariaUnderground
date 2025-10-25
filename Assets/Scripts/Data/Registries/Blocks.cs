using System.Collections.Generic;
using Environment;

namespace Data
{
    /* -------------------------
     * Список всех блоков в игре
     * -------------------------
     */
    
    public class Blocks
    {
        public static Dictionary<string, Block> Registry = new Dictionary<string, Block>();
        
        public static Block Air = new Block("air")
            .Set("Strength", 0f)
            .Set("Transparent", true)
            .Set("DropOnBreak", Drop.Empty);
        public static Block Dirt = new Block("dirt")
            .Set("Strength", 1f)
            .Set("Transparent", false)
            .Set("DropOnBreak", new Drop().AddItem("dirt", 1))
            .Set("MainSprite", Sprites.GetSprite("Dirt"));

        public static void RegisterAll()
        {
            Registry.Add("air", Air);
            Registry.Add("dirt", Dirt);
        }

        public static Block GetBlock(string name)
        {
            return Registry[name];
        }
    }
}
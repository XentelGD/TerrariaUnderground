using Environment;

namespace Data
{
    /* -------------------------
     * Список всех блоков в игре
     * -------------------------
     */
    
    public class AllBlocks
    {
        public static Block Air = new Block("air")
            .Set("Strength", 0f)
            .Set("Transparent", true)
            .Set("DropOnBreak", Drop.Empty);
    }
}
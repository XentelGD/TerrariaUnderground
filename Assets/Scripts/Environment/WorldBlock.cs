using System.Collections.Generic;
using Data;

namespace Environment
{
    /*
     * -------------------------------------------------------
     * Этот класс отвечает за блоки, которые осязаемы
     * -------------------------------------------------------
     */
    
    public class WorldBlock
    {
        public Block Block;
        public Dictionary<string, object> IndividualProperties = new Dictionary<string, object>();
        public BackgroundBlock BackgroundBlock;
    }
}
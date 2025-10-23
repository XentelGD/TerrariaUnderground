using System.Collections.Generic;
using Data;

namespace Environment
{
    
    /*
     * -------------------------------------------------------
     * Тут перечислены все блоки
     * -------------------------------------------------------
     */
    
    public class Block
    {
        public string ID;
        private Dictionary<string, object> Properties = new Dictionary<string, object>();


        public Block(string id)
        {
            ID = id;
        }

        public Block Set(string property, object value)
        {
            Properties[property] = value;
            return this;
        }

        public object Get(string property)
        {
            return Properties[property];
        }
    }
}
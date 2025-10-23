using System.Collections.Generic;

namespace Data
{
    
    /*
     * -------------------------------------------------------
     * Тут перечислены все фоновые блоки
     * -------------------------------------------------------
     */
    
    public class BackgroundBlock
    {
        public string ID;
        private Dictionary<string, object> Properties = new Dictionary<string, object>();


        public BackgroundBlock(string id)
        {
            ID = id;
        }

        public BackgroundBlock Set(string property, object value)
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
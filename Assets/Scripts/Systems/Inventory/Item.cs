using System.Collections.Generic;

namespace Data
{
    
    /* ------------------------------------------------------------------
     * Класс, реализующий предметы в игре
     * ------------------------------------------------------------------
     */
    
    public class Item
    {
        public string ID;
        private Dictionary<string, object> Properties = new Dictionary<string, object>();


        public Item(string id)
        {
            ID = id;
        }

        public Item Set(string property, object value)
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
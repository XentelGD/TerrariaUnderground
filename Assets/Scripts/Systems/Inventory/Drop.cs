using System;
using System.Collections.Generic;

namespace Data
{
    
    /* ------------------------------------------------------------------
     * Класс, который помогает удобно хранить дроп. Например, есть блок,
     * с которого при разрушении падает 2 алмаза и 1 кремень. Чтобы
     * удобно хранить эти значения, и нужен этот класс
     * ------------------------------------------------------------------
     */
    
    public class Drop
    {
        private List<Stack> DropItems = new List<Stack>();
        
        public static Drop Empty = new Drop();

        // Добавить в список дропов новый дроп
        public Drop AddItem(Item item, int amount)
        {
            DropItems.Add(new Stack(item, amount));
            return this;
        }
        
        // Добавить в список дропов новый дроп
        public Drop AddItem(Stack stack)
        {
            DropItems.Add(stack);
            return this;
        }
        
        // Очистить весь дроп
        public Drop ClearAll()
        {
            DropItems.Clear();
            return this;
        }
        
        public Drop()
        {
            
        }
        
        public Drop(Item item, int amount)
        {
            DropItems.Add(new Stack(item, amount));
        }
        
        public Drop(Stack stack)
        {
            DropItems.Add(stack);
        }
    }
}
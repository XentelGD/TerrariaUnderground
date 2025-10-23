using System.Collections.Generic;
using Data;

namespace Environment
{
    /*
     * -------------------------------------------------------
     * Этот класс хранит игровой мир
     * -------------------------------------------------------
     */
    public class World
    {
        // Размер мира в чанках
        public readonly int MaxChunkCount = 100;

        // Словарь с чанками мира
        public Dictionary<int, Chunk> chunks = new Dictionary<int, Chunk>();
        
        // Функция для получения блока по его глобальным координатам
        public WorldBlock GetWorldBlock(int globalX, int globalY)
        {
            int chunkCoordinate = globalX / 16;
            return chunks[chunkCoordinate].GetWorldBlock(globalX - chunkCoordinate * 16, globalY);
        }
        
        public bool IsWorldBlockAir(int globalX, int globalY)
        {
            return GetWorldBlock(globalX, globalY).Block == AllBlocks.Air;
        }

        public World()
        {
            
        }
    }
}
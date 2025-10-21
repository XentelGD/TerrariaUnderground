using System.Collections.Generic;

namespace Environment
{
    public class World
    {
        // Размер мира в чанках
        public readonly int MaxChunkCount = 100;

        // Словарь с чанками мира
        public Dictionary<int, Chunk> chunks = new Dictionary<int, Chunk>();
        
        // Функция для получения блока по его глобальным координатам
        public Block GetBlock(int globalX, int globalY)
        {
            int chunkCoordinate = globalX / 16;
            return chunks[chunkCoordinate].GetBlock(globalX - chunkCoordinate * 16, globalY);
        }
        
        public bool IsBlockAir(int globalX, int globalY)
        {
            return GetBlock(globalX, globalY).Type == BlockType.Air;
        }

        public World()
        {
            
        }
    }
}
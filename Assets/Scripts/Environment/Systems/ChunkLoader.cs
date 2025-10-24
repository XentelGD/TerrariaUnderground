using System.Collections.Generic;
using Data;
using UnityEngine;

namespace Environment.Systems
{
    
    /*
     * -------------------------------------------------------
     * Загрузчик чанков, благодаря нему оптимизируется
     * потребление ресурсов компьютера
     * -------------------------------------------------------
     */
    public class ChunkLoader
    {

        // Возвращает список чанков, которые расположены близко к камере
        public List<Chunk> GetLoadedChunks(Camera camera, Dictionary<int, Chunk> chunks)
        {
            
            float cameraChunkX = camera.transform.position.x / Constants.ChunkWidth / 2;
            List<Chunk> nearChunks = new List<Chunk>();
            for (int x = 0; x < Constants.RenderDistance * 2; x++)
            {
                nearChunks.Add(chunks[(int)cameraChunkX - Constants.RenderDistance + x]);
            }

            return nearChunks;
        }

    }
}
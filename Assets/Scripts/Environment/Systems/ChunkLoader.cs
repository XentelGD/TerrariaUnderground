using System.Collections.Generic;
using UnityEngine;

namespace Environment.Systems
{
    public class ChunkLoader
    {

        public List<Chunk> GetLoadedChunks(Camera camera, Dictionary<int, Chunk> chunks)
        {
            float cameraChunkX = camera.transform.position.x / 32;
            List<Chunk> nearChunks = new List<Chunk>();
            for (int x = 0; x < 10; x++)
            {
                nearChunks.Add(chunks[(int)cameraChunkX - 5 + x]);
            }

            return nearChunks;
        }

    }
}
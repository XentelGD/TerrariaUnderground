using System.Collections.Generic;
using UnityEngine;
using Environment;
using Environment.Systems;
using Render;

namespace Core
{
    
    /*
     * -------------------------------------------------------
     * Этот класс является входной точкой нашей игры.
     * Т.е. это главный класс
     * -------------------------------------------------------
     */
    
    public class GameManager : MonoBehaviour
    {
    
        private World World = new World();
        public Camera Camera;
        
        void Start()
        {
            for (int i = 0; i < 20; i++)
            {
                World.Chunks[i - 10] = new Chunk(i);
            }
            
            ChunkLoader loader = new ChunkLoader();
            List<Chunk> loadedChunks = loader.GetLoadedChunks(Camera, World.Chunks);

            foreach (Chunk chunk in loadedChunks)
            {
                ChunkRenderer.Setup(chunk);
            }
            
        }
        
        void Update()
        {
            
        }
    }
}
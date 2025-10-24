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
    
        public World World = new World();
        public Camera camera;
        public GameObject blockPrefab, blockContainer;

        void Start()
        {
            for (int i = 0; i < 20; i++)
            {
                World.Chunks[i - 10] = new Chunk(i - 10);
            }
            
            ChunkLoader loader = new ChunkLoader();
            List<Chunk> loadedChunks = loader.GetLoadedChunks(camera, World.Chunks);
            print(loadedChunks);

            foreach (Chunk chunk in loadedChunks)
            {
                ChunkRenderer.Setup(blockPrefab, blockContainer, chunk);
            }
            
        }
        
        void Update()
        {
            
        }
    }
}
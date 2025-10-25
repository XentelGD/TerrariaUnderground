using System.Collections.Generic;
using Data;
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
            Sprites.RegisterAll();
            Blocks.RegisterAll();
            Items.RegisterAll();
            
            
            for (int i = 0; i < 200; i++)
            {
                World.Chunks[i - 100] = new Chunk(i - 100);
            }
            
            ChunkLoader loader = new ChunkLoader();
            List<Chunk> loadedChunks = loader.GetLoadedChunks(camera, World.Chunks);

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
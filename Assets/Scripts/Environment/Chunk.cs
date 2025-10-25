using Data;
using UnityEngine;

namespace Environment
{
    
    /*
     * -------------------------------------------------------
     * Этот класс хранит небольшой кусок мира размером 16х324
     * -------------------------------------------------------
     */
    public class Chunk
    {
        public WorldBlock[,] WorldBlocks = new WorldBlock[Constants.ChunkWidth, Constants.ChunkHeight];
        public int Position;

        public Chunk(int position)
        {
            Position = position;
            
            for (int x = 0; x < Constants.ChunkWidth; x++)
            {
                for (int y = 0; y < Constants.ChunkHeight; y++)
                {
                    WorldBlock block = new WorldBlock();
                    block.Block = Blocks.Dirt;
                    WorldBlocks[x, y] = block;
                }
            }
        }

        public WorldBlock GetWorldBlock(int localX, int localY)
        {
            return WorldBlocks[localX, localY];
        }
    }
}
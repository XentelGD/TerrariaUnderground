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
        public WorldBlock[,] Blocks = new WorldBlock[16, 324];
        public int Position;

        public Chunk(int position)
        {
            Position = position;
            
            for (int x = 0; x < 16; x++)
            {
                for (int y = 0; y < 324; y++)
                {
                    Blocks[x, y] = new WorldBlock();
                }
            }
        }

        public WorldBlock GetWorldBlock(int localX, int localY)
        {
            return Blocks[localX, localY];
        }
    }
}
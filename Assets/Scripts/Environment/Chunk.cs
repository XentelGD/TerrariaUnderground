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

        public WorldBlock GetWorldBlock(int localX, int localY)
        {
            return Blocks[localX, localY];
        }
    }
}
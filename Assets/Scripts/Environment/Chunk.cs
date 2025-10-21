namespace Environment
{
    public class Chunk
    {
        public Block[,] Blocks = new Block[16, 324];

        public Block GetBlock(int localX, int localY)
        {
            return Blocks[localX, localY];
        }
    }
}
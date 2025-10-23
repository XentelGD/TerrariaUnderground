using Environment;
using UnityEngine;

namespace Render
{
    public class ChunkRenderer : MonoBehaviour
    {
        public static GameObject BlockPrefab;
        
        public static void Setup(Chunk chunk)
        {
            for (int x = 0; x < 32; x++)
            {
                for (int y = 0; y < 324; y++)
                {
                    GameObject block = Instantiate(BlockPrefab, new Vector3(x, y, 0), Quaternion.identity);
                }
            }
        }
    }
}
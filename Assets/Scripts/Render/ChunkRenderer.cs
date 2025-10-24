using Data;
using Environment;
using UnityEngine;

namespace Render
{
    
    /*
     * -------------------------------------------------------
     * Класс, который отрисовывает блоки в чанках
     * -------------------------------------------------------
     */
    public class ChunkRenderer : MonoBehaviour
    {
        
        // Создаёт блоки чанка, устанавливает их на сцену
        public static void Setup(GameObject blockPrefab, GameObject blockContainer, Chunk chunk)
        {
            for (int x = 0; x < Constants.ChunkWidth; x++)
            {
                for (int y = 0; y < Constants.ChunkHeight; y++)
                { 
                    // Создание клона заранее заготовленного объекта-образца (префаба)
                    GameObject block = Instantiate(
                        blockPrefab, 
                        new Vector3(
                            chunk.Position * (float)Constants.ChunkWidth / 2 + (float)x / 2, 
                            (float)y / 2, 0), 
                        Quaternion.identity
                    );
                    
                    // Этому клону устанавливается объект-родитель
                    block.transform.SetParent(blockContainer.transform);
                }
            }
        }
    }
}
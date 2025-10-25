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
                            chunk.Position * (float)Constants.ChunkWidth / 2 + (float)x, 
                            (float)y, 0), 
                        Quaternion.identity
                    );
                    
                    // Этому клону устанавливается объект-родитель
                    block.transform.SetParent(blockContainer.transform);

                    SpriteRenderer spriteRenderer = block.GetComponent<SpriteRenderer>();
                    
                    var blockData = chunk.GetWorldBlock(x, y).Block;
                    var mainSprite = blockData.Get("MainSprite") as Sprite;

                    if (mainSprite != null)
                    {
                        
                        float widthInUnits = mainSprite.rect.width / mainSprite.pixelsPerUnit;
                        float heightInUnits = mainSprite.rect.height / mainSprite.pixelsPerUnit;
    
                        float scaleX = 1f / widthInUnits;
                        float scaleY = 1f / heightInUnits;
    
                        spriteRenderer.sprite = mainSprite;
                        block.transform.localScale = new Vector3(scaleX, scaleY, 1f);
                        
                    }

                }
            }
        }
    }
}
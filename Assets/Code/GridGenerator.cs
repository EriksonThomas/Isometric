using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public GameObject tilePrefab;
    private int gridWidth = 9;
    private int gridHeight = 9;
    private float tileSpacing = 1.0f;

    private void Awake()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                //set the tile to the prefab set in the inspector
                GameObject tile = Instantiate(tilePrefab);

                //set the tile to across by 1/2 and down by 1/4
                float posX = (x * tileSpacing + y * tileSpacing) * 0.5f;
                float posY = (x * tileSpacing - y * tileSpacing) * 0.4f;
                
                //loop through each tile in the grid and center it to the screen
                tile.transform.position = new Vector2(posX - Mathf.RoundToInt((gridWidth) * tileSpacing * 0.5f), posY);
                tile.name = x + " , " + y;
                tile.GetComponent<Tile>().tilePosition.Item1 = x;
                tile.GetComponent<Tile>().tilePosition.Item2 = y;
            }
        }
    }
}
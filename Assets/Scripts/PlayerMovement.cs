using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Tilemap walkableTilemap;
    [SerializeField] Transform player;
    
    Vector3Int[,] walkableArea;
    BoundsInt bounds;
    
    // Start is called before the first frame update
    void Start()
    {
        //Trims any empty cells from the edges of the tilemap
        walkableTilemap.CompressBounds();
        bounds = walkableTilemap.cellBounds;

        CreateGrid();
    }
    
    private void CreateGrid()
    {
        walkableArea = new Vector3Int[bounds.size.x, bounds.size.y];
        for (int x = bounds.xMin, i = 0; i < (bounds.size.x); x++, i++)
        {
            for (int y = bounds.yMin, j = 0; j < (bounds.size.y); y++, j++)
            {
                if (walkableTilemap.HasTile(new Vector3Int(x, y, 0)))
                {
                    walkableArea[i, j] = new Vector3Int(x, y, 0);
                }
                else
                {
                    walkableArea[i, j] = new Vector3Int(x, y, 1);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Input.
    }
}

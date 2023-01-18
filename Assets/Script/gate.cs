using UnityEngine;
using UnityEngine.Tilemaps;

public class gate : MonoBehaviour
{
    public Tilemap myTilemap;
    public Tile closedGateTile;
    public Tile openedGateTile;

    public int x;
    public int y;
    public int z;

    void Update()
    {
        // Check if the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Get the current tile at the gate position
            TileBase currentTile = myTilemap.GetTile(new Vector3Int(x, y, z));

            // Check if the current tile is the closed gate tile
            if (currentTile == closedGateTile)
            {
                // Change the tile to the opened gate tile
                myTilemap.SetTile(new Vector3Int(x, y, z), openedGateTile);
            }
            else if (currentTile == openedGateTile)
            {
                // Change the tile to the closed gate tile
                myTilemap.SetTile(new Vector3Int(x, y, z), closedGateTile);
            }
        }
    }
}
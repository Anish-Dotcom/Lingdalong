using UnityEngine;
using UnityEngine.Tilemaps;

public class gate : puzzle1
{
    public GameObject uibox;
    public bool playerInRange;

    public Tilemap myTilemap;
    public Tile closedGateTile;
    public Tile openedGateTile;

    public GameObject interact;

    public int x;
    public int y;
    public int z;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerInRange)
        {
            if (uibox.activeInHierarchy)
            {
                uibox.SetActive(false);
            }
            else
            {
                uibox.SetActive(true);
            }
        }

        // Check if the space key is pressed
        if (finishedPuzzle == true)
        {
            // Get the current tile at the gate position
            TileBase currentTile = myTilemap.GetTile(new Vector3Int(x, y, z));

            // Check if the current tile is the closed gate tile
            if (currentTile == closedGateTile)
            {
                // Change the tile to the opened gate tile
                myTilemap.SetTile(new Vector3Int(x, y, z), openedGateTile);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            playerInRange = true;
            interact.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            playerInRange = false;
            uibox.SetActive(false);
            interact.SetActive(false);
    }
}
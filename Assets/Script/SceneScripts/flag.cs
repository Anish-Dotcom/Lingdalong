using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class flag : MonoBehaviour
{
    public Tilemap myTilemap;
    public Tile anim1;
    public Tile anim2;
    public Tile anim3;
    public Tile anim4;
    public Tile anim5;

    public int x;
    public int y;
    public int z;

    void Start()
    {
        StartCoroutine(anima1());
    }
    IEnumerator anima1()
    {
        yield return new WaitForSeconds(1);
        myTilemap.SetTile(new Vector3Int(x, y, z), anim1);
        StartCoroutine(anima2());
    }

    IEnumerator anima2()
    {
        yield return new WaitForSeconds(1);
        myTilemap.SetTile(new Vector3Int(x, y, z), anim2);
        StartCoroutine(anima3());
    }
    IEnumerator anima3()
    {
        yield return new WaitForSeconds(1);
        myTilemap.SetTile(new Vector3Int(x, y, z), anim3);
        StartCoroutine(anima4());
    }
    IEnumerator anima4()
    {
        yield return new WaitForSeconds(1);
        myTilemap.SetTile(new Vector3Int(x, y, z), anim4);
        StartCoroutine(anima5());
    }
    IEnumerator anima5()
    {
        yield return new WaitForSeconds(1);
        myTilemap.SetTile(new Vector3Int(x, y, z), anim5);
        StartCoroutine(anima1());
    }
}

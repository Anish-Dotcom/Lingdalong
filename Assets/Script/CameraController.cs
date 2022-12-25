using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public Tilemap themap;
    private Vector3 bottemLeftLimit;
    private Vector3 TopRightLimit;

    private float halfHight;
    private float halfwidth;

    // Start is called before the first frame update
    void Start()
    {
        //sets the boundry and target
        target = REALWALK.instance.transform;

        halfHight = Camera.main.orthographicSize;
        halfwidth = halfHight * Camera.main.aspect;

        bottemLeftLimit = themap.localBounds.min + new Vector3(halfwidth, halfHight, 0f);
        TopRightLimit = themap.localBounds.max + new Vector3(-halfwidth, -halfHight, 0f);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);


        transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottemLeftLimit.x, TopRightLimit.x),
                                 Mathf.Clamp(transform.position.y, bottemLeftLimit.y, TopRightLimit.y),
                                 transform.position.z);
    }
}
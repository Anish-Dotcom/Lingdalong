using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    public float swordSpeed;
    public GameObject sworditem;
    public Camera mainCamera;
    public GameObject gotopos;
    public Transform comebackpos;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) || Input.GetMouseButtonDown(1))
        {
            
            if (pickup.instance.swordimageactive == true)
            {
                Vector3 mouseScreenPosition = Input.mousePosition;
                Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(mouseScreenPosition);
                mouseWorldPosition.z = 0f;
                gotopos.transform.position = mouseWorldPosition;
                float distance = Vector3.Distance(sworditem.transform.position, gotopos.transform.position);
                sworditem.transform.position = Vector3.MoveTowards(sworditem.transform.position, gotopos.transform.position, Time.deltaTime * swordSpeed);
            }
        }
    }
}

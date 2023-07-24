using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    public float swordSpeed;
    public GameObject sworditem;
    public Camera mainCamera;
    public GameObject gotopos;
    public GameObject player;

    public bool swordGoing;

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
                swordSpeed = 15;
                Vector3 mouseScreenPosition = Input.mousePosition;
                Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(mouseScreenPosition);
                mouseWorldPosition.z = 0f;
                gotopos.transform.position = mouseWorldPosition;
                swordGoing = true;
            }
        }
        if (swordGoing == true)
        {
            float distance = Vector3.Distance(sworditem.transform.position, gotopos.transform.position);
            sworditem.transform.position = Vector3.MoveTowards(sworditem.transform.position, gotopos.transform.position, Time.deltaTime * swordSpeed);
            if (sworditem.transform.position == gotopos.transform.position)
            {
                swordSpeed = 8;
                StartCoroutine(comeback());
            }
        }
        if(swordGoing == false)
        {
            float distance = Vector3.Distance(sworditem.transform.position, player.transform.position);
            sworditem.transform.position = Vector3.MoveTowards(sworditem.transform.position, player.transform.position, Time.deltaTime * swordSpeed);
        }
    }

    IEnumerator comeback()
    {
        yield return new WaitForSeconds(2);
        swordGoing = false;
        float distance = Vector3.Distance(sworditem.transform.position, player.transform.position);
        sworditem.transform.position = Vector3.MoveTowards(sworditem.transform.position, player.transform.position, Time.deltaTime * swordSpeed);
    }
}

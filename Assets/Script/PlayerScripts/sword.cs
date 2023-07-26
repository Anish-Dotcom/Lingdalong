using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    public bool itstimetocomeback;
    public float swordSpeed;
    public GameObject sworditem;
    public Camera mainCamera;
    public GameObject gotopos;
    public GameObject player;
    public float rotationSpeed = 200f;
    public bool swordGoing;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        sworditem.transform.position = player.transform.position;
        sworditem.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current rotation of the GameObject
        Vector3 currentRotation = sworditem.transform.rotation.eulerAngles;

        // Calculate the new Z-axis rotation
        float newZRotation = currentRotation.z + (rotationSpeed * Time.deltaTime);

        // Create a new rotation with the updated Z-axis value
        Quaternion newRotation = Quaternion.Euler(currentRotation.x, currentRotation.y, newZRotation);

        // Apply the new rotation to the GameObject
        sworditem.transform.rotation = newRotation;

        if (Input.GetKeyDown(KeyCode.K) || Input.GetMouseButtonDown(1) && swordGoing == false)
        {
            
            if (pickup.instance.swordimageactive == true && REALWALK.instance.rb.velocity == new Vector2(0,0))
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
            sworditem.SetActive(true);
            float distance = Vector3.Distance(sworditem.transform.position, gotopos.transform.position);
            sworditem.transform.position = Vector3.MoveTowards(sworditem.transform.position, gotopos.transform.position, Time.deltaTime * swordSpeed);
            if (sworditem.transform.position == gotopos.transform.position)
            {
                swordSpeed = 10;
                itstimetocomeback = true;
            }
        }
        if (itstimetocomeback == true)
        {
            swordGoing = false;
            float distance = Vector3.Distance(sworditem.transform.position, player.transform.position);
            sworditem.transform.position = Vector3.MoveTowards(sworditem.transform.position, player.transform.position, Time.deltaTime * swordSpeed);
            itcameback();
        }
    }

    public void itcameback()
    {
        if (sworditem.transform.position == player.transform.position)
        {
            swordSpeed = 1000;
            float distance = Vector3.Distance(sworditem.transform.position, player.transform.position);
            sworditem.transform.position = Vector3.MoveTowards(sworditem.transform.position, player.transform.position, Time.deltaTime * swordSpeed);
            itstimetocomeback = false;
            sworditem.SetActive(false);
        }
        
    }

    
}

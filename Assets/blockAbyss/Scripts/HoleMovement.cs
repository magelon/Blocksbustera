using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleMovement : MonoBehaviour
{
    Camera camera;
    //last mouse position
    Vector3 lmp;

    float offsetY;
    float offsetX;

    public GameObject player;

    bool canMove;

    //positions
    public Vector3 poX;

    void Start()
    {
        camera = Camera.main;
    }

    
    void Update()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        var mousePos = Input.mousePosition;
        mousePos.z = 0.5f;
        //watch positions
        poX = Camera.main.ScreenToWorldPoint(mousePos);

        
        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;

            Debug.Log(objectHit.name);

            // Do something with the object that was hit by the raycast.
            if (Input.GetMouseButtonDown(0)&& objectHit.tag=="Player")
            {
                //record current mousePosition
                lmp = Camera.main.ScreenToWorldPoint(mousePos);
        
                canMove = true;
            }

            if (Input.GetMouseButton(0)&&canMove)
            {
                //Debug.Log("moving");
                offsetX = Camera.main.ScreenToWorldPoint(mousePos).x - lmp.x;
                offsetY = Camera.main.ScreenToWorldPoint(mousePos).y - lmp.y;

                
                player.transform.position = new Vector3(player.transform.position.x + offsetX, player.transform.position.y, player.transform.position.z + offsetY);

            }

            if (Input.GetMouseButtonUp(0))
            {
                canMove = false;
                offsetX = 0;
                offsetY = 0;
                lmp = new Vector3(0, 0, 0);
            }

        }
        
       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBehavior : MonoBehaviour
{
    int count;
    public cubeMatrix cm;
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Collider>().isTrigger = true;
        other.GetComponent<Rigidbody>().AddForce(-transform.up*1);
        GameManager.getInstance().playSfx("drop");
        count++;
        Debug.Log(count);
    }

    private void Update()
    {
        if (cm.count == count)
        {
            Debug.Log("win");
            GameData.getInstance().main.gameWin();
        }
    }

}

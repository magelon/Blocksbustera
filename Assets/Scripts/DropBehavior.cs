using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBehavior : MonoBehaviour
{
    int count;
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Collider>().isTrigger = true;
        other.GetComponent<Rigidbody>().AddForce(-transform.up*1);
        count++;
        Debug.Log(count);
    }

}

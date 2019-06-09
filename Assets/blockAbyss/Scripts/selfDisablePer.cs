/*
 * disable object to improve the performance
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfDisablePer : MonoBehaviour
{
    void FixedUpdate()
    {
        if (transform.position.y < -5)
        {
            gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMatrix : MonoBehaviour
{
    int x, y, z;
    public GameObject cube;

    void Start()
    {
        x = Random.Range(5, 8);
        y = Random.Range(5, 8);
        z = Random.Range(5, 8);

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                for (int k = 0; k < z; k++)
                {

                    Instantiate(cube, new Vector3(i, j, k), Quaternion.identity);
                }
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMatrix : MonoBehaviour
{
    int x, y, z;
    public GameObject cube;
	public int xStart,zStart;
    int count;

    void Start()
    {
        x = Random.Range(5, 8);
        y = Random.Range(5, 8);
        z = Random.Range(5, 8);

		x = x + xStart;
		z = z + zStart;

		for (int i = xStart; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
				for (int k = zStart; k < z; k++)
                {

                    Instantiate(cube, new Vector3(i, j, k), Quaternion.identity);
                    count++;
                    Debug.Log(count + "cubes");
                }
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMatrix : MonoBehaviour
{
    int x, y, z;
    public GameObject cube;
	public int xStart,zStart;
    public int count;

    void Start()
    {
        x = Random.Range(5, 8);
        y = Random.Range(5, 8);
        z = Random.Range(10, 15);

		x = x + xStart;
		z = z + zStart;

		for (int i = xStart; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
				for (int k = zStart; k < z; k++)
                {
                    if (Random.Range(0f, 10f) > 5f)
                    {
                        GameObject newCube = Instantiate(cube, new Vector3(i, j, k), Quaternion.identity);
                        newCube.GetComponent<Renderer>().material.color = new Color(
                        Random.Range(0f, 1f),
                        Random.Range(0f, 1f),
                        Random.Range(0f, 1f)
                        );
                        count++;
                        //Debug.Log(count + "cubes");
                    }
                   
                }
            }
        }

    }

}

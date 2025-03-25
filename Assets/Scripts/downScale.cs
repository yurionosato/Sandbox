using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downScale : MonoBehaviour
{
    public GameObject distObj;
    public float dist;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] cubeObjects = GameObject.FindGameObjectsWithTag("Cube");
        foreach (GameObject cube in cubeObjects)
        {
            //Debug.Log("Enemyタグを持ったオブジェクト名：" + enemy.name);
            float dis = Vector3.Distance(distObj.transform.position, cube.transform.position);
            if (dis <= dist)
            {
                cube.transform.localScale = new Vector3(10 * dis / dist,
                    10 * dis / dist,
                    10 * dis / dist);
            }
            else
            {
                cube.transform.localScale = new Vector3(10, 10, 10);
            }
        }

    }
}

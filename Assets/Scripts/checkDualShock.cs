using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkDualShock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Debug.Log("Horizontal axis: " + horizontal + ", Vertical axis: " + vertical);
    }
}

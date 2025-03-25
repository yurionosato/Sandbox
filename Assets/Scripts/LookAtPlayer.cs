using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    [SerializeField] private GameObject lookatObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var direction = lookatObj.transform.position - transform.position;
        var lookRotation = Quaternion.LookRotation(direction, Vector3.up);
        //transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, 1f);
        transform.rotation = lookRotation;
    }
}

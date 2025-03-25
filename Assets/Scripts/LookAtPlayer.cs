using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    [SerializeField] private GameObject lookatObj;
    private Vector3 initialPosition; // èâä˙à íu
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var direction = lookatObj.transform.position - transform.position;
        var lookRotation = Quaternion.LookRotation(direction, Vector3.up);
        //transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, 1f);
        transform.rotation = lookRotation;
        if(Vector3.Distance(transform.position, lookatObj.transform.position) < 15)
        {
            /*float speed = 1;
            Vector3 velocity = transform.rotation * new Vector3(0, 0, speed);
            transform.Translate(transform.position.x-lookatObj.transform.position.x, 0, transform.position.z-lookatObj.transform.position.z);*/
            transform.position -= new Vector3(transform.forward.x * 1f * Time.deltaTime, 0, transform.forward.z * 1f * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position,initialPosition, 1f * Time.deltaTime);
        }
    }
}

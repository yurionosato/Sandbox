using Oculus.Interaction.Samples;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEngine.InputManagerEntry;

public class autoWalking : MonoBehaviour
{
    [SerializeField] private GameObject go;
    [SerializeField] private GameObject lookatObj;
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float autoTime = 10f;
    float timer;
    bool auto = false;
    float randomTime = 0;
    float randomX = 0;
    float randomZ = 0;
    float randomUD = 0;
    float randomRL = 0;
    float yaw;
    float pitch;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        checkControl();
        autoMove();
    }

    void checkControl()
    {
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0 &&
            Input.GetAxis("JoyRightH") == 0 && Input.GetAxis("JoyRightV") == 0)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0f;
            auto = false;
        }

        if (timer > autoTime)
        {
            if(!auto)
            {
                setRandom();
            }
            auto = true;
        }
        else
        {
            auto = false;
        }
    }

    void autoMove()
    {
        if (auto)
        {
            if (timer < randomTime)
            {
                go.transform.Translate(randomX, 0, randomZ);
                yaw = go.transform.localEulerAngles.y - randomRL;
                pitch -= -randomUD;
                pitch = Mathf.Clamp(pitch, -50f, 50f);
                //go.transform.localEulerAngles = new Vector3(0, yaw, 0);
                if(lookatObj != null)
                {
                    var direction = lookatObj.transform.position - go.transform.position;
                    direction.y = 0;
                    var lookRotation = Quaternion.LookRotation(direction, Vector3.up);
                    go.transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, 0.5f);
                    //go.transform.LookAt(lookatObj.transform, Vector3.up);
                }
                //playerCamera.transform.localEulerAngles = new Vector3(pitch, 0, 0);
            }
            else
            {
                setRandom();
            }
        }
        else
        {
            initRandom();
        }
    }

    void setRandom()
    {
        randomTime = timer + UnityEngine.Random.Range(2f, 5f);
        randomX = UnityEngine.Random.Range(-1f, 1f) / 10;
        randomZ = UnityEngine.Random.Range(-1f, 1f) / 10;
        randomUD = UnityEngine.Random.Range(-1f, 1f) / 10;
        randomRL = UnityEngine.Random.Range(-1f, 1f) / 10;
    }

    void initRandom()
    {
        randomTime = 0;
        randomX = 0;
        randomZ = 0;
        randomUD = 0;
        randomRL = 0;
    }
}

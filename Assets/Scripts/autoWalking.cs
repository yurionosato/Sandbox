using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEngine.InputManagerEntry;

public class autoWalking : MonoBehaviour
{
    [SerializeField] private GameObject go;
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
        if(auto)
        {
            if (timer < randomTime)
            {
                go.transform.Translate(randomX, 0, randomZ);
                yaw = go.transform.localEulerAngles.y - randomRL;
                pitch -= - randomUD;
                pitch = Mathf.Clamp(pitch, -50f, 50f);
                go.transform.localEulerAngles = new Vector3(0, yaw, 0);
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

    void setRandom()
    {
        randomTime = timer + UnityEngine.Random.Range(2f, 5f);
        randomX = UnityEngine.Random.Range(-1f, 1f) / 30;
        randomZ = UnityEngine.Random.Range(-1f, 1f) / 30;
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

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class endingManager : MonoBehaviour
{
    public static bool gotoEnding = false;
    public GameObject player;
    public GameObject panel;
    private float timer = 0;
    private float n = 20;
    private float endTime = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gotoEnding)
        {
            player.GetComponent<OVRPlayerController>().enabled = false;
            if(timer > n)
            {
                panel.GetComponent<Image>().color = new Color(0, 0, 0, (timer - n) / endTime);
            }
            if(timer > n+endTime)
            {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif 
            }
            timer++;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class firstScene : MonoBehaviour
{
    [SerializeField] private GameObject img;
    [SerializeField] private GameObject videoPlayer;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(videoPlayer.GetComponent<VideoPlayer>().isPlaying == false && timer > 10)
        if(timer > 600)
        {
            img.SetActive(false);
            videoPlayer.SetActive(true);
        }
        if(timer > 1000)
        {
            SceneManager.LoadScene("VR01");
        }
        timer += 1f;
    }
}

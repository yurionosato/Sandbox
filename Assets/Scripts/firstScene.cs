using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;

public class firstScene : MonoBehaviour
{
    [SerializeField] private GameObject img;
    [SerializeField] private GameObject img2;
    private float timer = 0;
    private float fade = 30;
    private float show = 400;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(videoPlayer.GetComponent<VideoPlayer>().isPlaying == false && timer > 10)

        if (timer >= 0 && timer < fade)
        {
            img.GetComponent<Image>().color = new Color(1, 1, 1, timer / fade);
        }
        else if (timer < fade + show)
        {
            //showing
            img.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        }
        else if (timer < fade + show + fade)
        {
            img.GetComponent<Image>().color = new Color(1, 1, 1, 1 - (timer - fade - show) / fade);
        }
        else if (timer < fade + show + fade * 3 + fade)
        {
            //waiting
            img.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        }
        else if (timer < fade + show + fade * 3 + fade + fade)
        {
            img2.GetComponent<Image>().color = new Color(1, 1, 1, (timer-fade*5-show)/fade);
        }
        else if (timer < fade + show + fade * 3 + fade + fade + show)
        {
            //showing
            img2.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        }
        else if (timer < fade + show + fade * 3 + fade + fade + show + fade)
        {
            img2.GetComponent<Image>().color = new Color(1, 1, 1, 1-(timer-fade*6-show*2)/fade);
        }
        else if (timer < fade + show + fade * 3 + fade + fade + show + fade + fade)
        {
            img2.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        }
        else
        {
            SceneManager.LoadScene("VR01");
        }
        timer += 1f;
    }
}

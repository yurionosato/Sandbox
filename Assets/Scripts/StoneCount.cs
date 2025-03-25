using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneCount : MonoBehaviour
{
    private int counti = 0;
    private int pcount = 0;
    bool isPlayed = false;
    [SerializeField] private GameObject cross;
    [SerializeField] private AudioSource a;//AudioSource型の変数aを宣言 使用するAudioSourceコンポーネントをアタッチ必要

    [SerializeField] private AudioClip crash;//AudioClip型の変数b1を宣言 使用するAudioClipをアタッチ必要
    [SerializeField] private AudioClip path;//AudioClip型の変数b2を宣言 使用するAudioClipをアタッチ必要
    
    // Start is called before the first frame update
    public void counter() {
        counti++;
        Debug.Log(counti);
    
        if (counti >= 30) {

            //cross.SetActive(true);
        }
    }

    void Update()
    {
        if(pcount < counti)
        {
            a.PlayOneShot(crash);
        }
        if(counti >= 5)
        {
            cross.GetComponent<BoxCollider>().enabled = true;
            if (pcount < counti && !isPlayed)
            {
                a.PlayOneShot(path);
                isPlayed = true;
            }
        }
    }

    private void LateUpdate()
    {
        pcount = counti;
    }

}

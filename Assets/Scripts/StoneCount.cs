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
    [SerializeField] private AudioSource a;//AudioSource�^�̕ϐ�a��錾 �g�p����AudioSource�R���|�[�l���g���A�^�b�`�K�v

    [SerializeField] private AudioClip crash;//AudioClip�^�̕ϐ�b1��錾 �g�p����AudioClip���A�^�b�`�K�v
    [SerializeField] private AudioClip path;//AudioClip�^�̕ϐ�b2��錾 �g�p����AudioClip���A�^�b�`�K�v
    
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

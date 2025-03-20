using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    private static BGMManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // ƒV[ƒ“‚ğ‚Ü‚½‚¢‚Å‚à”jŠü‚³‚ê‚È‚¢
        }
        else
        {
            Destroy(gameObject); // Šù‚ÉBGMManager‚ª‘¶İ‚·‚é‚È‚çíœ
        }
    }
}
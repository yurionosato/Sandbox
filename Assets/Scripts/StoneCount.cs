using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneCount : MonoBehaviour
{
    private int counti = 0;
    [SerializeField]private GameObject cross;
    // Start is called before the first frame update
    public void counter() {
        counti++;
        Debug.Log(counti);
    
        if (counti >= 30) {

            cross.SetActive(true);
        }
    }
        
}

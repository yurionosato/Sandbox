using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    private Animator m_Animator = null;
    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }
    public void ScuareClick()
    {
        m_Animator.SetTrigger("Action");
    }
    public void BRClick() {
        m_Animator.SetTrigger("Cube");
    }
    public void URClick()
    {
        m_Animator.SetTrigger("Mochi");
    }

}

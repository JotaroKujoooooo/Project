using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    public Animator anim;

    public void St()
    {
        anim.SetBool("anim", true);
    }
    public void Stop()
    {
        anim.SetBool("anim", false);
    }
}

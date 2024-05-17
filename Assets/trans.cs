using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trans : MonoBehaviour
{
    public GameObject detail;
    public GameObject telega;
    void Start()
    {
        detail.transform.parent=telega.transform;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class take_zag_1 : MonoBehaviour
{
    public GameObject detail;
    public GameObject hand;
    public GameObject telega;
    IEnumerator Start()
    {
        detail.transform.parent = hand.transform;
        yield return new WaitForSeconds(4);
        detail.transform.parent = telega.transform;
    }
}

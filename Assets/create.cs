using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{
    public GameObject detail;
    public GameObject scene;
    public GameObject hand;
    IEnumerator Start()
    {
        yield return new WaitForSeconds(2);
        detail.SetActive(true);
        //detail.transform.parent = scene.transform;
        //yield return new WaitForSeconds(3);
        //detail.transform.parent=hand.transform;
        //yield return new WaitForSeconds(3);
        //detail.transform.parent = scene.transform;
    }

}

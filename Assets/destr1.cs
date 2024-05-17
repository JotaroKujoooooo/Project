using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destr1 : MonoBehaviour
{
    public GameObject zag;
    IEnumerator Start()
    {
        yield return new WaitForSeconds(2);
        Destroy(zag);
    }
}

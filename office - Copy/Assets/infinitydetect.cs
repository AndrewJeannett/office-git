using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infinitydetect : MonoBehaviour {
    public GameObject pos;
    private void OnTriggerEnter(Collider col)
    {
if (col.CompareTag ("Player")){
            pos.transform.Translate(0, +1000, 0);
       
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private GameObject targetPindah;
    //private Vector3 posisiTarget;
    [SerializeField]
    private GameObject bola;

   
    private void OnTriggerEnter(Collider other)
    {
        if (other == bola.GetComponent<Collider>())
        {
            bola.transform.position = new Vector3(targetPindah.transform.position.x, bola.transform.position.y, targetPindah.transform.position.z);
        }
    }
}

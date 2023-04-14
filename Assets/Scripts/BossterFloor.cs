using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossterFloor : MonoBehaviour
{
    [SerializeField]
    private Collider bola;
    [SerializeField]
    private float speed;

    private void OnTriggerEnter(Collider other)
    {
       if(other == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= speed;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public Material onMaterial;
    public Material offMaterial;
    private bool isOn;
    private Renderer render;

    public Collider _bola;

    private void Start()
    {
        render = GetComponent<Renderer>();
        Set(false);
        render.material = offMaterial;
        
    }

   

    private void OnTriggerEnter(Collider other)
    {
        if (other == _bola)
        {
            Set(!isOn);
        }
    }
   
    private void Set(bool active)
    {
        isOn = active;
        if (isOn == true)
        {
            render.material = onMaterial;
        }
        else
        {
            render.material = offMaterial;
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarParticles : MonoBehaviour
{

    [SerializeField] private ParticleSystem starParticles; 

    // Start is called before the first frame update
    void Start()
    {
        if (starParticles != null)
        {
            starParticles.Stop();
        }
    }

    private void OnMouseEnter()
    {
        if (starParticles != null)
        {
            starParticles.Play();
            //Debug.Log("Mouse Entered");
        }
    }

    private void OnMouseExit()
    {
        if (starParticles != null)
        {
            starParticles.Stop();
            //Debug.Log("Mouse LEFT");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public float footstepDistance;
    private Vector3 lastPosition; 
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        lastPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float currentDistance = Vector3.Distance(lastPosition, transform.position);

        if (currentDistance > footstepDistance)
        {

            PlayFootstep();
            currentDistance = 0;
            lastPosition = transform.position;
        }
        
    }
    public void PlayFootstep()
    {
        audioSource.pitch = Random.Range(0.8f, 1.2f);
        audioSource.Play();
    }
}


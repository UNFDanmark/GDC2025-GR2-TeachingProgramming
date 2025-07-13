using System;
using UnityEngine;

public class AIEyes : MonoBehaviour
{
    RaycastHit hit;
    bool hitSomething;

    public float sightDistance;
    

    // Update is called once per frame
    void Update()
    {
        hitSomething = Physics.Raycast(transform.position, transform.forward, out hit, sightDistance);

        if (hitSomething)
        {
            if (hit.transform.CompareTag("Player"))
            {
                print("Hejsa spillere jeg kan faktisk se dig ;)");
            }
            else
            {
                print("hmmm hvor er du");
            }
        }
    }

    void OnDrawGizmos()
    {
        if (hitSomething && hit.transform.CompareTag("Player"))
        {
            Gizmos.color = Color.green;
        }
        else
        {
            Gizmos.color = Color.red;
        }
        
        Gizmos.DrawRay(transform.position, transform.forward * sightDistance);
    }
}

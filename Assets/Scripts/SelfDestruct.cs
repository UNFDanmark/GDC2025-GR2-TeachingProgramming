using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    [SerializeField] float liveTime;
    float timeLived;

    // Update is called once per frame
    void Update()
    {
        timeLived += Time.deltaTime;
        if (timeLived >= liveTime)
        {
            Destroy(gameObject);
        }
    }
}

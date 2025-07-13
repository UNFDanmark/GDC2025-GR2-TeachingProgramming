using UnityEngine;

public class Bullet : MonoBehaviour
{
    float lifeTime = 2f;
    

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}

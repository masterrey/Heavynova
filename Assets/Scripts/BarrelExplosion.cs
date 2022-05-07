using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelExplosion : MonoBehaviour
{

    public GameObject explosion;
    public int life = 3;

    private void OnParticleCollision(GameObject other)
    {
        life--;

        if (life < 0)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}

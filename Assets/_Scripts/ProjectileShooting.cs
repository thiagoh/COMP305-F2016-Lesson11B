using UnityEngine;
using System.Collections;

public class ProjectileShooting : MonoBehaviour {

    public Rigidbody projectile;
    public Transform flashPoint;

    public float ProjectileForce = 500.0f;
    public float FireRate = 0.25f;

    private float NextFireTime;

    void Update() {

        if (Input.GetButtonDown("Fire2") && Time.time > NextFireTime) {

            Rigidbody cloneRB = Instantiate(projectile, flashPoint.position, Quaternion.identity) as Rigidbody;
            cloneRB.AddForce(flashPoint.transform.forward * ProjectileForce);
            NextFireTime = Time.time + FireRate;
        }
    }
}

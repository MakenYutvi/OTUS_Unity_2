using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Velocity = 5;
    private Transform Target;

    public void Init(Vector3 from, Transform target)
    {
        Target = target;
        transform.position = from;
        // выстрел по физике
        GetComponent<Rigidbody2D>().AddForce((target.position - from).normalized * 1000);
    }

    // погоня за целью с равной скоростью
    //void Update()
    //{
    //    transform.position += (Target.position - transform.position).normalized
    //        * Velocity * Time.deltaTime;
    //}
}

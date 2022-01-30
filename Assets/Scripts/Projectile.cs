using UnityEngine;

[RequireComponent(typeof(CapsuleCollider))]
public class Projectile : MonoBehaviour
{
    public float speed = 20f;
    public Vector3 direction = Vector3.up;
    public System.Action<Projectile> destroyed;
    public new CapsuleCollider collider { get; private set; }

    private void Awake()
    {
        collider = GetComponent<CapsuleCollider>();
    }

    private void OnDestroy()
    {
        if (destroyed != null) {
            destroyed.Invoke(this);
        }
    }

    private void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    /*private void CheckCollision(Collider2D other)
    {
        Bunker bunker = other.gameObject.GetComponent<Bunker>();

        if (bunker == null || bunker.CheckCollision(collider, transform.position)) {
            Destroy(gameObject);
        }
    }*/

    /*private void OnTriggerEnter2D(Collider other)
    {
        //CheckCollision(other);
    }

    private void OnTriggerStay2D(Collider other)
    {
        //CheckCollision(other);
    }*/

}

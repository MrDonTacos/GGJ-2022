using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public Projectile laserPrefab;
    public System.Action killed;
    public bool laserActive { get; private set; }
    [SerializeField] private GameObject bulletA;
    [SerializeField] private GameObject bulletB;
    [SerializeField] private Transform bulletAPos;
    [SerializeField] private Transform bulletBPos;
    private bool isRed = true;
    

    private void Update()
    {
        Vector3 position = transform.position;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            //position.x -= speed * Time.deltaTime;
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            //position.x += speed * Time.deltaTime;
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= Vector3.up * speed * Time.deltaTime;
        }

        /*Vector3 leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);
        Vector3 rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right);

        // Clamp the position of the character so they do not go out of bounds
        position.x = Mathf.Clamp(position.x, leftEdge.x, rightEdge.x);
        transform.position = position;
        */
        if (Input.GetKeyDown(KeyCode.X) || Input.GetMouseButtonDown(0)) {
            if(!bulletB.active && !bulletA.active)
            {
                PrepareBullet(bulletA, bulletAPos);
            }
        }
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetMouseButtonDown(1)) {
            if(!bulletB.active && !bulletA.active)
            {
                PrepareBullet(bulletB, bulletBPos);            
            }
        }
    }

    private void Shoot()
    {
        // Only one laser can be active at a given time so first check that
        // there is not already an active laser
        /*if (!laserActive)
        {
            laserActive = true;

            Projectile laser = Instantiate(laserPrefab, transform.position, Quaternion.identity);
            laser.destroyed += OnLaserDestroyed;
        }*/

        //Instantiate(laserPrefab, transform.position, Quaternion.identity);
    }

    /*private void OnLaserDestroyed(Projectile laser)
    {
        laserActive = false;
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Missile") ||
            other.gameObject.layer == LayerMask.NameToLayer("Invader"))
        {
            if (killed != null) {
                killed.Invoke();
            }
        }
    }

    void PrepareBullet(GameObject bullet, Transform bulletPosition)
    {
            bullet.transform.position = bulletPosition.position;
            bullet.SetActive(true);
        if(!isRed)
            isRed = true;
        else
            isRed = false;
    }

}

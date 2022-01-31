using UnityEngine;
using UnityEngine.SceneManagement;

//[RequireComponent(typeof(SpriteRenderer))]
public class Invader : MonoBehaviour
{
    //public SpriteRenderer spriteRenderer { get; private set; }
    //public Sprite[] animationSprites = new Sprite[0];
    public float animationTime = 1f;
    public int animationFrame { get; private set; }
    public int score = 10;
    public System.Action<Invader> killed;

    private void Awake()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
        //spriteRenderer.sprite = animationSprites[0];
    }

    private void Start()
    {
        //InvokeRepeating(nameof(AnimateSprite), animationTime, animationTime);
    }

    /*private void AnimateSprite()
    {
        animationFrame++;

        // Loop back to the start if the animation frame exceeds the length
        if (animationFrame >= animationSprites.Length) {
            animationFrame = 0;
        }

        spriteRenderer.sprite = animationSprites[animationFrame];
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BulletBlue" && gameObject.name == "AlienShip_01(Clone)")
            killed?.Invoke(this);
        else if(other.tag == "BulletRed" && gameObject.name == "AlienShip_02(Clone)")
            killed?.Invoke(this);
    }

}

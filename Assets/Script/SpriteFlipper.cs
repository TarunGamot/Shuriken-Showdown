using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlipper : MonoBehaviour
{
    public float speed;
    private SpriteRenderer mySpriteRenderer;
    public float jumpForce;
    private Rigidbody2D _rigidbody;
    public float dashSpeed;
    public ParticleSystem dashEffect;
    public ParticleSystem jumpEffect;
    public float bounds;
    public AudioSource jumpSound;
    
    public float downForce;
    public bool onGround;



    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Awake()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        Movement();
        JumpMovement();




        if (onGround == false)
        {
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.down * Time.deltaTime * downForce);
            }
        }
        
        



       
    }
    public void Movement()
    {
        if (transform.position.x < -bounds)
        {
            transform.position = new Vector3(-bounds, transform.position.y, transform.position.z);
        }
        if (transform.position.x > bounds)
        {
            transform.position = new Vector3(bounds, transform.position.y, transform.position.z);
        }
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        if (!Mathf.Approximately(0, movement))
        {
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;

            if (Input.GetKey(KeyCode.A))
            {
                if (Input.GetKey(KeyCode.K))
                {

                    CreateDust();
                    transform.Translate(new Vector3(movement, 0, 0) * Time.deltaTime * dashSpeed);
                }

            }
            if (Input.GetKey(KeyCode.D))
            {
                if (Input.GetKey(KeyCode.K))
                {

                    CreateDust();
                    transform.Translate(new Vector3(movement, 0, 0) * Time.deltaTime * -dashSpeed);
                }

            }
        }
    }
    public void JumpMovement()
    {
        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) <= 0.00)
        {
            onGround = false;

            jumpEffect.Play();
            jumpSound.Play();
            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
    
    
    
    void OnCollisionEnter2D(Collision2D ground)
    {
        onGround = ground.gameObject.tag == "Ground";
    }
    void CreateDust()
    {
        dashEffect.Play();
    }
}

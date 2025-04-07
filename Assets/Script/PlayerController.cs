using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
   
    public float horizontaIn;
    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {

        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0,0)* Time.deltaTime * speed;
        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y)< 0.00)
        {
            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
        

        //if (!Mathf.Approximately(0, movement))
          //  transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
       
    }
}

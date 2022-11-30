using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Vector2 movementDirection;     //"SerializeField" significa que desde el inspector podemos  manipular o ver su valor.
    [SerializeField] float speed;
    public Rigidbody rigidbody_;
    private bool jumpPressed = false;
    [SerializeField] private float jumpForce;               //Agregamos una variable flotante para agrear furza al 
    [SerializeField] bool canJump = true;
    public bool escal= false;
    [SerializeField] float sub;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody_ = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        jumpPressed = Input.GetButtonDown("Jump");

        rigidbody_.velocity = new Vector3(movementDirection.x * speed, rigidbody_.velocity.y, rigidbody_.velocity.z);               
        if (jumpPressed && canJump)
        {
            rigidbody_.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            Debug.Log(rigidbody_.velocity.y);
            canJump = false;
        }

        if (rigidbody_.velocity.y == 0)
        {
            canJump = true;
        }

        if(escal)
        {
            this.gameObject.transform.position += new Vector3(0,sub*Time.deltaTime,0);
        }

    }

  
}

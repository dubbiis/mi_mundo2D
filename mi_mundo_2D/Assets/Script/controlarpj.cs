using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlarpj : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    Rigidbody2D rigidBody;
    private float inputMovement;
    public bool isLookingRight = true;
    
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        ProcessingMovement();
    }
    void CharacterOrientation(float inputMovement)
    {
        if ((isLookingRight && inputMovement < 0) || (!isLookingRight && inputMovement > 0))
        {
            isLookingRight = !isLookingRight;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }

    void ProcessingMovement()
    {
        inputMovement = Input.GetAxis("Horizontal");
        rigidBody.velocity = new Vector2(inputMovement * speed, rigidBody.velocity.y);


        //Movement logic
        inputMovement = Input.GetAxis("Horizontal");
        rigidBody.velocity = new Vector2(inputMovement * speed, rigidBody.velocity.y);
        CharacterOrientation(inputMovement);

    }

}



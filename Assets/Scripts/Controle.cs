using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Controle : MonoBehaviour
{

    private Rigidbody2D rb;
    private float dirX;

    private float dirY;
    private float moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
        dirY = CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed;
        rb.velocity = new Vector2(dirX, dirY);
        print(dirX + "  diry " +dirY);

        if(this.gameObject.transform.position.y >= 8f){
            this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, 8f);
        }
        GetComponent<Animator>().SetBool("idle", (CrossPlatformInputManager.GetAxis("Vertical") == 0));

        
        
    }

    /*void FixedUpdate () {
	input = new Vector3(Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
	if(rigidbody.velocity.magnitude < maxSpeed)
	{
		rigidbody.AddRelativeForce(input * moveSpeed);
	} //
    */
}

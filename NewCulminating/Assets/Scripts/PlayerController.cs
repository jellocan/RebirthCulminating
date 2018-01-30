using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    /// <summary>
    /// Get ready for alot of comment notes :3
    /// </summary>
    public float moveSpeed; //player movement speed, public makes it editable in unity ui
    private Animator anim; //create an object to reference blank doesnt know which one
    private static bool playerExists; //check wheter i have an instance of player, static makes all objexts share variables
    private Rigidbody2D Myrigidbody2D;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();//set the reference to animator attached to player
        Myrigidbody2D = GetComponent<Rigidbody2D>();
        if (!playerExists)
        {
            playerExists = true;
            DontDestroyOnLoad(transform.gameObject);//when new level is loaded maks this stay in exisitnece
        }
        else
        {
            Destroy (gameObject);
        }

	}
	
	// Update is called once per frame
	void Update () {
#region player movement checks
        if(Input.GetAxisRaw("Horizontal")>0.5f || Input.GetAxisRaw("Horizontal") < -0.5f) //edit project settings input, this uses the prebuilt controller thingy
        {
            Myrigidbody2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal" ) * moveSpeed * Time.deltaTime, Myrigidbody2D.velocity.y);
            
            //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime,0f,0f)); //vector 3 is x y z
        }
        
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f) //edit project settings input, this uses the prebuilt controller thingy
        {
            Myrigidbody2D.velocity = new Vector2(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime);

            //transform.Translate(new Vector3(0f,Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime,0f)); //vector 3 is x y z
        }
        
        if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > - 0.5f)
        {
            Myrigidbody2D.velocity = new Vector2(0f, Myrigidbody2D.velocity.y);

        }
        if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
        {
            Myrigidbody2D.velocity = new Vector2(Myrigidbody2D.velocity.x,0f);

        }
        #endregion
        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));//set variables for animations
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
    }

    
}

using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    //this is the player movement method

    void PlayerMovement()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);        
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKey(KeyCode.S)) 
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.A)) 
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.D)) 
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }

}

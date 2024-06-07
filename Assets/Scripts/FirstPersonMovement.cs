using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{

    public float speed;
    public CharacterController controller;
    public Transform player;
    public Transform FirstPersonCamera;
    public int mouseSensitivity;
    private float inputX = 0f;
    private float inputY = 0f;



    void Start()
    {
        // makes cursor invisable centering the cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;


    }

    // Update is called once per frame
    void Update()

    {
        // Gets the input for x and y axis 
        float xMovement =  Input.GetAxis("Horizontal");
        float yMovement = Input.GetAxis("Vertical");

        // creates vector that player will move with
        
        Vector3 move= new Vector3(xMovement, 0, yMovement);
        // transforms move vector so that it moves in direction of camera
        move = Camera.main.transform.TransformDirection(move);
        move.y = 0;
        // uses character controller component to move player
       
        controller.SimpleMove( move *speed);

        //Gets x and y axis for mouse position
        inputX = inputX -Input.GetAxis("Mouse X")*mouseSensitivity;

        // restricts inputY as to not allow the player to look above or below 90 degrees 
        inputY =  Mathf.Clamp(inputY - Input.GetAxis("Mouse Y")*mouseSensitivity, -90f, 90f);
        

        //changes player rotation to allow player to look around
        player.rotation = Quaternion.Euler(inputY,-1*(inputX),0);





    }

}
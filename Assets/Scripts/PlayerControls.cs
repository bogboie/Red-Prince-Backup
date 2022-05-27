using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour{
    public float speed = 0;
    public GameObject follower;
    public GameObject follower1;
    public GameObject follower2;
    public GameObject follower3;
    public GameObject follower4;
    public GameObject follower5;
    public GameObject follower6;
    public GameObject follower7;
    public GameObject follower8;
    public GameObject follower9;
    public GameObject follower10;
    public GameObject follower11;
    public GameObject follower12;
    public GameObject follower13;
    public GameObject follower14;
    public GameObject follower15;
    public GameObject follower16;
    public GameObject follower17;
    public GameObject follower18;
    public GameObject follower19;
    public GameObject follower20;
    public GameObject follower21;
    public GameObject follower22;
    public GameObject follower23;

    private Rigidbody rb;
    private float movementX;
    private float movementY;
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    private void OnMove(InputValue movementValue){
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate(){
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Spawn short soldier")){
            other.gameObject.SetActive(false);
            follower.SetActive(true);
            follower1.SetActive(true);
            follower2.SetActive(true);
        }
        if (other.gameObject.CompareTag("spawnSoldier")){
            follower4.SetActive(true);
        }
    }
}

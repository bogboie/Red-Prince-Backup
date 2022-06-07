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
    public GameObject follower24;
    public GameObject follower25;
    public GameObject follower26;
    public GameObject follower27;
    public GameObject follower28;
    public GameObject follower29;
    public GameObject follower30;
    public GameObject follower31;
    public GameObject follower32;
    public GameObject follower33;
    public GameObject follower34;
    public GameObject block;
  
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private int spawnCount = 0;
    private int numSoldiers = 0;
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
        if (other.gameObject.CompareTag("Spawn short soldier") && spawnCount == 0){
            other.gameObject.SetActive(false);
            follower.SetActive(true);
            follower1.SetActive(true);
            follower2.SetActive(true);
            follower3.SetActive(true);
            follower4.SetActive(true);
            spawnCount++;
            numSoldiers = numSoldiers + 5;
        }
        else if (other.gameObject.CompareTag("Spawn short soldier") && spawnCount == 1) {
            other.gameObject.SetActive(false);
            follower5.SetActive(true);
            follower6.SetActive(true);
            follower7.SetActive(true);
            follower8.SetActive(true);
            follower9.SetActive(true);
            spawnCount++;
            numSoldiers = numSoldiers + 5;
        }
        else if (other.gameObject.CompareTag("Spawn short soldier") && spawnCount == 2) {
            other.gameObject.SetActive(false);
            follower10.SetActive(true);
            follower11.SetActive(true);
            follower12.SetActive(true);
            follower13.SetActive(true);
            follower14.SetActive(true);
            spawnCount++;
            numSoldiers = numSoldiers + 5;
        }
        else if (other.gameObject.CompareTag("Spawn short soldier") && spawnCount == 3)
        {
            other.gameObject.SetActive(false);
            follower15.SetActive(true);
            follower16.SetActive(true);
            follower17.SetActive(true);
            follower18.SetActive(true);
            follower19.SetActive(true);
            spawnCount++;
            numSoldiers = numSoldiers + 5;
        }
        else if (other.gameObject.CompareTag("Spawn short soldier") && spawnCount == 4)
        {
            other.gameObject.SetActive(false);
            follower20.SetActive(true);
            follower21.SetActive(true);
            follower22.SetActive(true);
            follower23.SetActive(true);
            follower24.SetActive(true);
            spawnCount++;
            numSoldiers = numSoldiers + 5;
        }
        else if (other.gameObject.CompareTag("Spawn short soldier") && spawnCount == 5)
        {
            other.gameObject.SetActive(false);
            follower25.SetActive(true);
            follower26.SetActive(true);
            follower27.SetActive(true);
            follower28.SetActive(true);
            follower29.SetActive(true);
            spawnCount++;
            numSoldiers = numSoldiers + 5;
        }
        else if (other.gameObject.CompareTag("Spawn short soldier") && spawnCount == 6)
        {
            other.gameObject.SetActive(false);
            follower30.SetActive(true);
            follower31.SetActive(true);
            follower32.SetActive(true);
            follower33.SetActive(true);
            follower34.SetActive(true);
            numSoldiers = numSoldiers + 5;
        }
        else if(other.gameObject.CompareTag("Block") && numSoldiers == 35)
        {
            block.gameObject.SetActive(false);
        }
    }
}

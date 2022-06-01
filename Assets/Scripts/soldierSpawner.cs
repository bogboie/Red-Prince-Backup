using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldierSpawner : MonoBehaviour
{
    public float speed = 0;
    public Transform prince;
    public GameObject soldier;
    public Vector3 offset;
    public float min = 2f;
    public float max = 3f;

    // Start is called before the first frame update
    void Start()
    {
        soldier.SetActive(false);
        min = transform.position.x;
        max = transform.position.x + 3;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = prince.position + offset;
        transform.position = new Vector3(Mathf.PingPong(Time.time * 2, max - min) + min, transform.position.y, transform.position.z);
    }
}

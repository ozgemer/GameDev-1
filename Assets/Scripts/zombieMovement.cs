using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieMovement : MonoBehaviour
{
    [SerializeField]private GameObject wayPoint;
    private Vector3 wayPointPos;
    [SerializeField] GameObject objToFollow;
    Vector3 direction;
    [SerializeField] float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        wayPointPos = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);

        //direction = objToFollow.transform.position - transform.position;
        //GetComponent<Rigidbody>().velocity = direction.normalized * speed;
    }
}

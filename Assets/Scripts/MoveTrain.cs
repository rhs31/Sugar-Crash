using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrain : MonoBehaviour {
    public GameObject goal;
    public Rigidbody rb;
    public float forwardForce = 4000f;
    public float sidewaysForce = 100f;
    public bool isTurning = false;
    public bool isTeleporting = false;
    public int leftCount = 0;
    public int rightCount = 0;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update () {
        if (!isTeleporting)
             rb.AddForce(-(forwardForce * Time.deltaTime), 0, 0);
        if(Input.GetKeyDown("d"))
        {
            //rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            if(leftCount < 1)
            {
                Vector3 moveVector = new Vector3(3.7f, 0, 0);
                transform.localPosition += moveVector;
                leftCount++;
                rightCount--;
            }
            
            
        }
        if (Input.GetKeyDown("a"))
        {
            //rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            if(rightCount < 1)
            {
                Vector3 moveVector = new Vector3(3.7f, 0, 0);
                transform.localPosition -= moveVector;
                rightCount++;
                leftCount--;
            }
            
        }
        /*if(rb.position.y < -1f) // if player falls off, end game
        {
            FindObjectOfType<GameManager>().EndGame();
        }*/
    }
    public void TurnLeft()
    {
        Debug.Log("turning left");
        isTurning = true;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //Quaternion tempQuat = transform.rotation;
        //Quaternion turnRotation = Quaternion.Euler(new Vector3(0, 90, 0));
        //tempQuat.ToEuler = tempQuat.ToEuler + turnRotation.ToEuler;
        //isTurning = false;



    }
    public void TurnRight()
    {
        //Debug.Log("turning right");
        //isTurning = true;
        //rb.velocity = Vector3.zero;
        //rb.angularVelocity = Vector3.zero;
        ////rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        ////Quaternion turnRotation = Quaternion.Euler(new Vector3(0, 90, 0));
        ////transform.rotation = turnRotation;
        //////isTurning = false;

        //Vector3 relativePos = goal.transform.position - transform.position;
        //Quaternion rotation = Quaternion.LookRotation(relativePos);
        //transform.rotation = rotation;
        //while(((this.transform.position.x - goal.transform.position.x) < 0) && ((this.transform.position.y - goal.transform.position.y) < 0)&& ((this.transform.position.z - goal.transform.position.z) < 0))
        //{
        //    rb.AddForce((forwardForce * Time.deltaTime), 0, 0);
        //}

        transform.position = new Vector3(-272, 1, 295);
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        rb.AddForce((forwardForce * Time.deltaTime), 0, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {
    public GameManager gameManager;
    public Transform terrainPrefab;
    public GameObject player;
    public GameObject spawn;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Instantiate(terrainPrefab, new Vector3(transform.position.x - 923f, -1, -222f), terrainPrefab.rotation);
            //Instantiate(terrainPrefab, new Vector3(transform.position.x - -999.5f, 0, 0f), terrainPrefab.rotation);
            //player.transform.position = spawn.transform.position;
            Vector3 newVector = new Vector3(950, 0, 0);
            player.transform.position += newVector;

            Quaternion tempQuat = player.transform.rotation;
            tempQuat.eulerAngles = new Vector3(0, -90, 0);
            player.transform.rotation = tempQuat;
        }



    }

}

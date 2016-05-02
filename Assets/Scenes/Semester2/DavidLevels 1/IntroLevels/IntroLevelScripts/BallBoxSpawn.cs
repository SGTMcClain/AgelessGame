using UnityEngine;
using System.Collections;

public class BallBoxSpawn : MonoBehaviour {
    // Writen by David Hendricks

    public GameObject spawnPoint; // emprty gameobject or any gameobject you want to be the spawn point
    public GameObject ball; // ball or box gameobject or whatever you want to be spawned
    private Object spawnedObject; //since the object is a prefab. puts the prefab into a object, so we can destroy it

    private bool spawned; // so we can know if a ball/box is spawned or not spawned and run a check. 

    private int ballCount; // for our loop. We don't want extra balls/boxes spawning.

    private CharacterSwitch babyActive;


    // Use this for initialization
    void Start() {
        spawned = false; // we start the game with no ball/boxes spawned

        ballCount = 0; // we start the game with no ball/box spawned

        bool babyActive = GetComponent<CharacterSwitch>();
    }

    // Update is called once per frame
    void Update() {

        // if there are no ball/box spawned runs the BallSpawner function

        if (spawned == false)
        {


            BallSpawner();

        }
        if (spawned == true)
        {
            BallDespawn();  //despawn/destroys the ball/box
        }
    } 





    public void BallSpawner() {
        if ( spawned ==false && Input.GetKeyDown(KeyCode.E))
        {

            // when the ball/box count is below 0 and you press E and there are no ball/box spawned, spawns a ballbox at the location of the spawn point. Increases ball count to 1
            while (ballCount < 1 ) { 
           spawnedObject =Instantiate(ball, spawnPoint.transform.position, Quaternion.identity);
                //spawned = true;
                ballCount++; 
            }

            StartCoroutine(SpawnedSwitchTrue()); // we have to wait a second to make spawned true to preven the BallDespawn() from executing at the same time.
        }

      
    }


    public void BallDespawn()
    {
        // despawns/destroys the ball/box with E key only when there is a spawned ball/box and ball count equal 1. Sets the ball count back to 0 and spawned to 0
        if (spawned == true)
        {
            if (Input.GetKeyDown(KeyCode.E) || babyActive.disableBaby== true)
            {
                while (ballCount == 1)
                {
                    Destroy(spawnedObject);
                    ballCount--;

                }
                spawned = false;
            }
            }

    }

    IEnumerator SpawnedSwitchTrue() // sets spawned to true after 1 second used in BallSpawner()
    {

        yield return new WaitForSeconds(1f); 
        spawned = true;
    }


}


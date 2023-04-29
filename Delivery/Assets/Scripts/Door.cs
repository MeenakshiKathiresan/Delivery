using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Direction doorDirection;

    Civilian civilian;

    public Direction DoorDirection
    {
        get
        {
            return doorDirection;
        }
        set
        {
            doorDirection = value;
        }
    }


    bool isDestination = false;

    public bool IsDestionation
    {
        get
        {
            return isDestination;
        }
        set
        {
            isDestination = value;
        }
    }

    bool hasEnemies = false;

    public int currentFloor;
    public int currentDoor;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor()
    {
        

        if (isDestination)
        {
            //level up
        }
        else if (hasEnemies)
        {

        }
        else
        {
            string directionToSpawn = "";
            switch (doorDirection)
            {
                case Direction.right:
                    directionToSpawn = "right";
                    break;
                case Direction.left:
                    directionToSpawn = "left";
                    break;
                case Direction.up:
                    directionToSpawn = "up";
                    break;
                case Direction.down:
                    directionToSpawn = "down";
                    break;
            }

            civilian = (Civilian)PoolManager.Instantiate(directionToSpawn, transform.position, transform.rotation);

        }

        transform.localScale = Vector3.zero;
        StartCoroutine(CloseDoor());

    }

    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(LevelSettings.instance.doorWaitTime);
        transform.localScale = Vector3.one;

        civilian.PoolDestroy();
    }
}

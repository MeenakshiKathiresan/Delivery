using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    int currentFloor;

    public int CurrentFloor
    {
        set { currentFloor = value; }
        get { return currentFloor; }
    }

    [SerializeField]
    List<Door> doors = new List<Door>();

    public List<Door> Doors
    {
        get
        {
            return doors;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

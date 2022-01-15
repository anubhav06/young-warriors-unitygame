using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArrowHandler : MonoBehaviour {

    int index = 0;
    public int totalLevels = 2;
    public float yOffset = 1f;
	
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.S))
        {
            if(index <= totalLevels-1)
            {
                index++;
                Vector2 position = transform.position;
                position.y -= yOffset;
                transform.position = position;
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (index >0)
            {
                index--;
                Vector2 position = transform.position;
                position.y += yOffset;
                transform.position = position;
            }
        }
    }
}

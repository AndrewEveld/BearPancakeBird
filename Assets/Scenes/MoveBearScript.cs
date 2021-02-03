using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBearScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(position.x, transform.position.y);
    }
}

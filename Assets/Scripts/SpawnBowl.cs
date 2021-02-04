using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBowl : MonoBehaviour
{

    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine("DropBall");

    }

    // Update is called once per frame
    void Update()
    {

    }

    

    IEnumerator DropBall()
    {
        yield return new WaitForSeconds(2f);
        for (; ; )
        {


            Instantiate(ball);
            yield return new WaitForSeconds(Random.Range(1f, 1.5f));
            ball.transform.position = new Vector2(Random.Range(-8, 8), 5.5f);

        }
    }
}

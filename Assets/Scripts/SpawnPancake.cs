using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPancake : MonoBehaviour
{

    public GameObject pancake;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("DropPancake", 2f, .5f);
        StartCoroutine("DropPancake2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DropPancake()
    {
        Instantiate(pancake);
    }

    IEnumerator DropPancake2()
    {
        yield return new WaitForSeconds(2f);
        for (; ; )
        {


            Instantiate(pancake);
            yield return new WaitForSeconds(Random.Range(.5f,1f));
            pancake.transform.position = new Vector2(Random.Range(-8, 8), 10);

        }
    }
}

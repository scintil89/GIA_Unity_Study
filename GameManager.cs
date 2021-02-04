using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    public GameObject coin;
    float timer = 0.0f;
    float creatTime = 5.0f;

    static public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > creatTime)
        {
            float x = UnityEngine.Random.Range(-10.0f, 10.0f);
            float z = UnityEngine.Random.Range(-10.0f, 10.0f);

            Instantiate(coin, new Vector3(x, 1, z), Quaternion.identity);

            timer = 0.0f;
        }

        timer += Time.deltaTime;
    }
}

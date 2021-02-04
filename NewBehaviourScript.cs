using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject gm;

    public Transform cameraTransform;
    public float rotSpeed = 1.0f;
    public float moveSpeed = 10.0f;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(Vector3.up * rotSpeed * mouseX);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(x, 0, z);
        moveDirection = cameraTransform.TransformDirection(moveDirection);
        moveDirection *= moveSpeed;
        
        GetComponent<CharacterController>().Move(moveDirection * Time.deltaTime);

        if (z > 0)
        {
            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    
        if (collision.transform.tag == "Coin")
        {
            Debug.Log("OnCollisionEnter Coin");

            Destroy(collision.gameObject);

            GameManager.score++;
        }
    }
}

            //Destroy(collision.gameObject);
            //
            ////GameObject.Find("GameManager").GetComponent<GameManager>().score++;
            //
            //GameManager.score++;
            //
            //Debug.Log(GameManager.score);
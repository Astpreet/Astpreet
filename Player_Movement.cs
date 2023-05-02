using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public Transform transform;
    public float speed = 0.5f;
    public float rotationSpeed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()

    {

        Movement();
        Clamp();
    }
    void Movement()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -47), rotationSpeed * Time.deltaTime );
        } 
        if(Input.GetKey(KeyCode.LeftArrow))
        {
transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
 transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 47), rotationSpeed * Time.deltaTime );

        }

        if(transform.rotation.z != 90)
        {
             transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), 10f * Time.deltaTime );
        }
    }
void  Clamp()
{
       Vector3 pos = transform.position;
       pos.x = Mathf.Clamp(pos.x, -3f, 2.8f);
       transform.position = pos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Cars")

        {
            Time.timeScale = 0;
        }
    }
}

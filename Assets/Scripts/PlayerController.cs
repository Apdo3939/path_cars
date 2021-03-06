using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float limitLeft;
    public float limitRight;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float currentXposition = Mathf.Clamp((
            transform.position.x + Input.GetAxis("Horizontal")),
             limitLeft, limitRight);

        transform.position = Vector3.Lerp(transform.position,
        new Vector3(
            currentXposition,
            transform.position.y,
            transform.position.z),
            movementSpeed * Time.deltaTime
        );

        if(Input.GetButtonDown("Fire1")){
            Time.timeScale = 1.5f;
        }
        if(Input.GetButtonUp("Fire1")){
            Time.timeScale = 1f;
        }
        if(Input.GetButtonDown("Fire2")){
            Time.timeScale = 0.5f;
        }
        if(Input.GetButtonUp("Fire2")){
            Time.timeScale = 1f;
        }
    }

}

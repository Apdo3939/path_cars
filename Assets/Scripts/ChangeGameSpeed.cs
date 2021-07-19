using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGameSpeed : MonoBehaviour
{
    public float maxSpeed = 2.5f;
    public float speedMultiplier = 0.01f;

    public float currentSpeed = 1;
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        currentSpeed += speedMultiplier * Time.deltaTime;
        Time.timeScale = Mathf.Clamp(currentSpeed, 1, maxSpeed);

    }
}

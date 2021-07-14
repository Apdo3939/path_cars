using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{

    public Vector2 direction;
    
    public float speed;

    public Material roadMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        roadMaterial.SetTextureOffset("_MainTex", (direction * speed) * Time.time);
    }
}

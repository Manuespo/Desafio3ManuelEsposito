using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject balas;
    public float cooldown = 3f;
    void Start()
    {
        InvokeRepeating("creacionDeBalas", 2f, cooldown);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void creacionDeBalas()
    {
        Instantiate(balas);
    }
}

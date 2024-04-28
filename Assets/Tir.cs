using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tir : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OncollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}

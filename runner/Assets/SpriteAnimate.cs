using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteAnimate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     gameObject.GetComponent<Image>().enabled = false;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

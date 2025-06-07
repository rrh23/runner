using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyDrinkScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.isEDCollected)
        {
            gameObject.SetActive(false);
        }
        else gameObject.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    public void OnTriggerEnter(Collider other) 
    {
        if (other.name == "Ball") 
        {
            Destroy(this.gameObject);
        }
    }
}

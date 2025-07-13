using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.CompareTag("Player"))
      {
         Destroy(gameObject);
      }
   }
}

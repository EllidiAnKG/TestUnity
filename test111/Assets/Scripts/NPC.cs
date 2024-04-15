using UnityEngine;
using UnityEngine.UI;
using Valve.VR; 

public class NPC : MonoBehaviour
{
    public GameObject uiPanel; 
    

    private bool isPlayerNearby = false;

<<<<<<< HEAD
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
=======
  private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
>>>>>>> 0cbfc64a4075fe1c7c90d000b84f832cf7e5ab98
        {
            Debug.Log("enter");
            isPlayerNearby = true;
            uiPanel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            isPlayerNearby = false;
            uiPanel.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activator : MonoBehaviour
{
    public GameObject[] firstGroup;
    public GameObject[] SecondGroup;
    public Activator button;
    public Material normal;
    public Material transparent;
    public bool CanPush;
    private void OnTriggerEnter(Collider other)
    {
        if (CanPush)
        {
            if (other.CompareTag("Cube") || other.CompareTag("Player"))
            {
                foreach (GameObject item in firstGroup)
                {
                    item.GetComponent<Renderer>().material = normal;
                    item.GetComponent<Collider>().isTrigger = false;
                }
                foreach (GameObject item in SecondGroup)
                {
                    item.GetComponent<Renderer>().material = transparent;
                    item.GetComponent<Collider>().isTrigger = true;
                }
                GetComponent<Renderer>().material = transparent;
                button.GetComponent<Renderer>().material = normal;
                button.CanPush = true;
            }
        }
    }
}

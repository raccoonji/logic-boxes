using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLight : MonoBehaviour
{
    private float size =  0.25f;
    private void Start()
    {
        StartCoroutine(Rot());
    }

    //Update is called once per frame
    void FixedUpdate()
    {
        
    }
    IEnumerator Rot()
    {
        while (true)
        {
            for (int i = 0; i < 175; i++)
            {
                yield return new WaitForSeconds(0.05f);
                GetComponent<Transform>().Rotate(0, -size, 0);
                i++;
            }
            yield return new WaitForSeconds(15f);
            for (int i = 0; i < 175; i++)
            {
                yield return new WaitForSeconds(0.05f);
                GetComponent<Transform>().Rotate(0, size, 0);
                i++;
            }
        }
        
    }
}

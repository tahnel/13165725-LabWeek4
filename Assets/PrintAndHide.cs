using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    int i = 0;
    int j = 0;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        j = Random.Range(200, 250);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Red"))
        {
            if (i == 100)
                gameObject.SetActive(false);
        }
        if (gameObject.CompareTag("Blue"))
        {
            if (i == j)
                gameObject.GetComponent<Renderer>().enabled = false;
        }
        Debug.Log(gameObject.name + ": " + i);
        i++;
    }
}

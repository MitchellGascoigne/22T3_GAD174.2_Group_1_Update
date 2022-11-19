using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollManager: MonoBehaviour
{
    public GameObject Scroll;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void WhenButtonClicked()
    {
        if (Scroll.activeInHierarchy == true)
            Scroll.SetActive(false);
        else
            Scroll.SetActive(true);
    }
}

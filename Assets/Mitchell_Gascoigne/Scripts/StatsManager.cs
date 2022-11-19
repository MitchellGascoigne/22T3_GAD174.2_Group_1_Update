using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsManager: MonoBehaviour
{
    public GameObject Stats;
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
        if (Stats.activeInHierarchy == true)
            Stats.SetActive(false);
        else
            Stats.SetActive(true);
    }
}

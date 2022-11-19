using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] AudioSource SFX;
    public void LoadMitchScene()
    {
        SceneManager.LoadScene("Mitchell_Gascoigne");
    }

    public void LoadSashaScene()
    {
        SceneManager.LoadScene("");
    }

    public void LoadAnScene()
    {
        SceneManager.LoadScene("An.V_Scene");
    }

    public void PlaySound()
    {
        SFX.Play();
    }
}

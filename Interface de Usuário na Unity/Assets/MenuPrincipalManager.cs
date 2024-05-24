using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private string Maco;

    public void EnterMacoButton()
    {
        SceneManager.LoadScene("Maco");
    }
}

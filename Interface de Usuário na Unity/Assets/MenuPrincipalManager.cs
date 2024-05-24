using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private string jogo;

    public void botao()
    {
        SceneManager.LoadScene("jogo");
    }
}

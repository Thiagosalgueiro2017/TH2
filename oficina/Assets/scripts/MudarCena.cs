using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarCena : MonoBehaviour
{

    public void menu()
    {
        SceneManager.LoadScene("MarianaOUfavela");
    }
    public void Config()
    {
        SceneManager.LoadScene("Configuracao");
    }
    public void sair()
    {
        Application.Quit();
    }
    public void Favela()
    {
        SceneManager.LoadScene("Favela");
    }
    public void Mariana()
     {
       SceneManager.LoadScene("Mg1");
     }
}
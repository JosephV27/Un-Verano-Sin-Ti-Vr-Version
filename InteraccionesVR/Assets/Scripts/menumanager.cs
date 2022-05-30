using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{
    // Start is called before the first frame update
  
    public void cargarEscena(int numescena)
    {

        SceneManager.LoadScene(numescena);

    }

    public void salirApp()
    {
        Application.Quit();
    }
}

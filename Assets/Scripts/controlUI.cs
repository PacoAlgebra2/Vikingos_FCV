using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class controlUI : MonoBehaviour
{

    public void activarAyuda(GameObject ob){
        ob.SetActive(true);
    }

    public void cerrarAyuda(GameObject ob){
        ob.SetActive(false);
    }

    public void cargarNivel(int i){
        SceneManager.LoadScene(i);
    }

    public void salir(){
        Application.Quit();
    }

}

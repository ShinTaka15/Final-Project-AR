using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{
    public void pindahScene(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }
}

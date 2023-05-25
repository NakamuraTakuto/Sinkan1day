using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagemet : MonoBehaviour
{
    [SerializeField] string _sceanName;

    public void Change()
    {
        SceneManager.LoadScene(_sceanName);
    }
}

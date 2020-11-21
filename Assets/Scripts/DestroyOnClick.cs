using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DestroyOnClick : MonoBehaviour
{
    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        Destroy(gameObject);
    }
}
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Gamekit2D;

public class DestroyOnClick : MonoBehaviour
{
    void OnMouseDown()
    {
        DamageSelf();
        Score.Increment();
    }

    private void OnBecameInvisible()
    {
        DamageSelf();
    }

    private void DamageSelf()
    {
        Damageable damageable = gameObject.GetComponent<Damageable>();
        Damager damager = gameObject.GetComponent<Damager>();
        damageable.TakeDamage(damager);
    }
}
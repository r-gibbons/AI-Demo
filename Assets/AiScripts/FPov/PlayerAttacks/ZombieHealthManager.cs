using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealthManager : MonoBehaviour
{
    float ZombieHealth =100;

    void Update()
    {
        if (ZombieHealth <= 0)
        {
            this.gameObject.SetActive(false);
            ZombieHealth = 100;
        }
    }

    public void SetHealth(float healthChange)
    {
        ZombieHealth += healthChange;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SelectElement;

public class ShootWeapon : MonoBehaviour
{
    float bulletDamage =-10;
    
    [SerializeField]
    Camera cam;

    /*[SerializeField]
    ParticleSystem mFlash;*/
    
    

    ZombieHealthManager HealthManager;

    [SerializeField]
    float WeaponRange;
    

    ShotTypes ElementType;

    //every three items changes type ie 0 = bullet 1 = fire 2 = ice 3 = electric
    //The following values desribe inital damage, and damage done over time
    // 4th value is how long time damage lasts
    IDictionary<int, (int, int, int)> dict = new Dictionary<int, (int, int, int)>()
    {
        { 0, (-25, 0,0)},
        { 1, (-20,-20,5) },
        { 2, (-20,-10,10)},
        { 3, (-20,-10,10)}
    };

    int[] ElementProps = { 0, 25, 0,   1, 20, 20,   2, 20, 15,    3, 20, 10 };
    void OnShoot()
    {
        Debug.Log(dict[0].Item1);
        //mFlash.Play();
        Vector3 rayOrigin = cam.ViewportToWorldPoint(new Vector3(.5f, .5f, 0));
        RaycastHit hit;
        
        if (Physics.Raycast(rayOrigin,cam.transform.forward,out hit, WeaponRange))
        {
            Debug.Log("hit");
            if (hit.collider.CompareTag("Enemy"))
            {
                Debug.Log("close enough");
                HealthManager = hit.collider.GetComponent<ZombieHealthManager>();
                ElementType = SelectElement.ShotType;
                HealthManager.SetHealth(bulletDamage);
                //OnHit();
            }
            
        }
        
    }

   /* void OnHit()
    {
        switch ((int)ElementType)
        {
            case 0:
                bulletDamage = dict[0].Item1;
                HealthManager.SetHealth(bulletDamage);

        }
        
    }*/
    void OnEnable()
    {
        InputManager.OnLeftClick += OnShoot;
    }
    void OnDisable()
    {
        InputManager.OnLeftClick -= OnShoot;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SelectElement : MonoBehaviour
{
    public enum ShotTypes
    {
        Bullet, //0
        Fire,   //1
        Ice,    //2
        Elec    //3
    }

    public static ShotTypes ShotType;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            switch (this.gameObject.tag) {
                case "Fire":
                    ShotType = ShotTypes.Fire;
                    break;
                case "Ice":
                    ShotType = ShotTypes.Ice;
                    break;
                case "Electric":
                    ShotType = ShotTypes.Elec;
                    break;
                }
        }
        Debug.Log(ShotType);
    }
}

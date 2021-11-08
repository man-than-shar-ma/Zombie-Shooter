using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform muzzle;
    public Projectile projectile;
    public float msbwshots = 100;
    public float muzzleVelocity = 30;

    float nextShotTime;

    public void shoot(){
        if(Time.time > nextShotTime){
            nextShotTime = Time.time + msbwshots/1000;
            Projectile newProjectile = Instantiate(projectile, muzzle.position, muzzle.rotation) as Projectile;
            newProjectile.setSpeed(muzzleVelocity);
        }
    }
}

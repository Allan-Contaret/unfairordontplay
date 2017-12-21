using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShootScript : MonoBehaviour
{

    public GameObject PrefabBullet;
    public Transform BulletStartPosition;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator Shoot()
    {

        while (GameObject.Find("SJ001_run"))
        {
            GameObject Bullet = Instantiate<GameObject>(PrefabBullet);
            Bullet.transform.position = BulletStartPosition.position;
            Bullet.GetComponent<Rigidbody>().AddForce(BulletStartPosition.forward * 2000);
            yield return new WaitForSeconds(2);
        }
    }
}

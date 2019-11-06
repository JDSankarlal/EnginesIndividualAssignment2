using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{   
    public GameObject bullet;
    public int POOL_SIZE;
    public List<GameObject> poolOfBullets;
    //TODO: create a structure to contain a collection of bullets
    

    // Start is called before the first frame update
    void Start()
    {
        poolOfBullets = new List<GameObject>();
        for (int i=0;i<POOL_SIZE;i++)
        {
            GameObject obj = (GameObject)Instantiate(bullet); 
            obj.SetActive(false);
            poolOfBullets.Add(obj);
        }
        // TODO: add a series of bullets to the Bullet Pool
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO: modify this function to return a bullet from the Pool
    public GameObject GetBullet()
    {

        GameObject firstBullet = poolOfBullets[0];
        poolOfBullets.RemoveAt(0);
        firstBullet.SetActive(true);
       return firstBullet;
    }

    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {

    }
}

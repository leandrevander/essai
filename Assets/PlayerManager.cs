using System;
using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour
{
    public int pv;
    public GameObject zombie;
    private CircleCollider2D playerCollider;
    private bool peutPrendreDesDegats = true;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Zombie") && peutPrendreDesDegats)
        {
            StartCoroutine(PertePV(1f));
        }
    }

    IEnumerator PertePV(float delai)
    {
        peutPrendreDesDegats = false;
        pv--;
        print(pv);
        if (pv <= 0)
        {
                print("Game Over");
        }
        yield return new WaitForSeconds(1);
        peutPrendreDesDegats = true;
    }


}


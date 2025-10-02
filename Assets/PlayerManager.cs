using System;
using UnityEngine;
using System.Collections;
using UnityEngine.AI;


public class PlayerManager : MonoBehaviour
{
    public int pv;
    private CircleCollider2D playerCollider;
    public bool peutPrendreDesDegats = true;
    public NavMeshAgent zombieAgent;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

   // private void OnTriggerStay2D(Collider2D other)
   // {
        //if (other.CompareTag("Zombie") && peutPrendreDesDegats)
       // {
           //StartCoroutine(PertePV());
       // }
   // }

    public IEnumerator PertePV()
    {
        peutPrendreDesDegats = false;
        pv--;
        print(pv);
        if (pv <= 0)
        {
                print("Game Over");
                //zombieAgent.enabled = false;
                gameObject.SetActive(false);   
        }
        yield return new WaitForSeconds(1);
        peutPrendreDesDegats = true;
    }


}


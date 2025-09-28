using UnityEngine;
using UnityEngine.AI;

public class IAZombie : MonoBehaviour
{
    private GameObject player;
    public NavMeshAgent agent;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            agent.destination = player.transform.position;
   
        }
        
    }
}

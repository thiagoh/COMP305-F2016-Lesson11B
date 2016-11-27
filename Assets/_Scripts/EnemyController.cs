using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    // PUBLIC INSTANCE VARIABLES
    public NavMeshAgent Agent;

    // PRIVATE INSTANCE VARIABLES
    private Transform player;
    private bool agentEnabled;

    // Use this for initialization
    void Start() {
        player = GameObject.FindWithTag("Player").transform;
        agentEnabled = true;
    }

    // Update is called once per frame
    void Update() {
        if (agentEnabled) {
            Agent.SetDestination(this.player.position);
        }
    }

    public void disableAgent() {
        agentEnabled = false;
    }
}

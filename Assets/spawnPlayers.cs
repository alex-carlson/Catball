using UnityEngine;
using System.Collections;

public class spawnPlayers : MonoBehaviour {

    public float spawnArea = 20;

	// Put in HFT stuff here to spawn players.  We'll use Random.insideUnitCircle * spawnArea to spawn players I think.

    void OnDrawGizmosSelected()
    {

        // visualize the spawn area
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, spawnArea);
    }
}

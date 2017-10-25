using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager; // a public variable for access inside/outside the script, for the GameManager component, named gameManager.

    private void OnTriggerEnter() // using OnTriggerEnter method instead of start/update because we want the script to trigger from the gameobject trigger this script is attached to.
    {
        gameManager.CompleteLevel(); // Once triggered by gameobject this script is attached to it will run this function from a public member in GameManager.cs called CompleteLevel()
    }
}

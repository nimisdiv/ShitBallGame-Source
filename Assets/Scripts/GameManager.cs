using UnityEngine;
using UnityEngine.SceneManagement; // added because we are using the SceneManagement component of unity to change scenes on depending on the results of the code

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false; // private bool variable called gameHasEnded and is set to false

    public float restartDelay = 1f; // public float called restartDelay and is equal to 1 by default but is changeable in the unity editor the f defines its a float datatype number

    public GameObject completeLevelUI; // public variable using GameObject component of unity defined as completeLevelUI

    public void CompleteLevel () // Public void member can be accessed outside this script and returns the code below once called
    {
        completeLevelUI.SetActive(true); // this code sets the visibility of the completed level ui screen to true once called from the false default the gameobject for the ui screen is set in unity and referenced by our variabled completeLevelUI
    }

    public void EndGame() // this public void method can be access outside this script and returns the code below once called
    {
        if (gameHasEnded == false) // if statement is false by default, the parameters for the if statement are is if our bool called gameHasEnded == false 
        {
            gameHasEnded = true; // we set the gameHasEnded variable to = true so it only runs this if statement once
            Debug.Log("GAME OVER");// writes a string or info from a paramater in the console of the unity editor
            Invoke("Restart", restartDelay);// invokes the method "Restart" in restartDelay seconds, 1 by default but can be changed in unity editor.
        }
    }

    void Restart () // this private void method cant be accessed outside this script and returns the code below once called, results in a restart
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);// uses the SceneManager componenet of unity from the using UnityEngine.SceneManagement; we access the LoadScene Method with the paramaters of SceneManager.GetActiveScene().name to restart the same scene on call
    }

}

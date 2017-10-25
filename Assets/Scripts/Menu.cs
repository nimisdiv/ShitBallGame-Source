using UnityEngine;
using UnityEngine.SceneManagement; // using UnityEngine.SceneManagement was added to this script because we want it to reference things from the SceneManagement unity component

public class Menu : MonoBehaviour {

	public void StartGame() // we create a public function called StartGame() that can be accessed from outside the script
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // once StartGame() is called this code will access the SceneManager.LoadScene function with the paramaters to be the same as the current scenes buildindex + 1 using (SceneManager.GetActiveScene().buildIndex + 1);, this give us the ability to start the game from a UI Menu Scene with a build order of 00 and the first level being 01
    }
}

using UnityEngine;
using UnityEngine.SceneManagement; // added because we are using the SceneManagement component of unity to change scenes on level complete.

public class LevelComplete : MonoBehaviour {

	public void LoadNextLevel () // public method from Unity Scene management will load the next level/scene on call with parameters
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Code here uses the unity scene manager.Loadscene to load the next scene once called by gameobject logic, Its paramaters are to use SceneManager.GetActiveScene().buildIndex to get the current active scene's buildindex and increments it by 1, example Level01, has a build index of 00 so this will result as the parameter being set to 01, current level + 1 = next level
    }

}

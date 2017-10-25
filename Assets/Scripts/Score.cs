using UnityEngine;
using UnityEngine.UI; // Added because we want to reference the UnityEngine.UI.Text component

public class Score : MonoBehaviour {

    public Transform player; // Public variable can be reference from outside the script, using Transform component of unity reponsible for position, varible named player
    public Text scoreText; // Public variable can be referenced from outside the script, using Text component of UnityEngine.UI; for referencing text, varible named scoreText

	// Update is called once per frame
	void Update () {
        scoreText.text = player.position.z.ToString("0"); // Once every frame scoreText variable is called and equaled to that of the player game game object, requires a string for the UI text so we use .ToString(), then change it to .ToString(0) to display a whole number.
	}
}

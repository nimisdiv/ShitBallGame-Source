using UnityEngine;

public class Credits : MonoBehaviour {

	public void Quit() // we create a public Quite() function within this script that can be called from outside this script oncee called it will run the code below
    {
        Debug.Log("Quit"); // Unity doesnt quit the game in the editor so this is here to print to the console to verify the code ran.
        Application.Quit(); // Here we use a c# component Application and call its Quit() function, in a built enviroment this will result in the application in closing down.
    }
}

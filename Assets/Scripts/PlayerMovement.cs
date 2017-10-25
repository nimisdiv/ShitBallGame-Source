using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    //This is a refernce to the Rigidbody Component called "rb"
    public Rigidbody rb;

    public float forwardForce = 500f; // public float datatype variable named forwardForce, public can be used outside the script and we can change this in the unity editor
    public float sidewaysForce = 500f; // public float datatype variable named sidewayForce, public can be used outside this script and we can change this in the unity editor

    // We marked this as "Fixed"Update method because we
    // are using it to mess with physics unity optimisation prefers it, REMEMBER THIS YOU CUNT IT COULD BE USEFUL!

	void FixedUpdate ()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // every frame this function is run using our rb varaible, to define which rigidbody we want to add force to using AddForce function from Rigidbody unity component defined in our rb variable
                                                          // AddForce uses a similar parameters to Vector3 data type defined as x,y,z, in our function we want it to only apply a force we define with the forwardForce variable we can change in the unity editor so we use, (0, 0, forwardForce * Time.deltaTime); as the paramaters to achieve this effect then mutiplied by Time.deltaTime which is the time taken in seconds to complete the last frame, this kinda universally controls the speed on the player at all framerates, insstead of being onconsistant at different framerates. REMEMBER THIS U CUNT!!
        if (Input.GetKey("d")) // if statement run alost every frame, the if statements paramater is false until the d key is pressed then its true and runs the code below otherwise it skips the code
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // this code uses our rb variable and the AddForce function from the Rigidbody component in unity it uses our sideaysForce variable * Time.deltaTime(returns the fixed framerate delta time when run in FixedUpdate) , doesnt change y,z axis by being set to 0,0, and ForceMode.VelocityChange on called this will apply the velocity change instantly, this mode will change the velocity of every single rigidbody the same way regardless of differces in mass. This mode the froce parameter is applied to rigidbody as distance/time
        }

        if (Input.GetKey("a")) // if statement run almost every frame, the if statement is the same as the one above but -sidewaysForce to go the opposite direction on the same axis and using the a key for input
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) // if statement run almost every frame, the if statements is false by default but once our rigidbody's .position.y is less than < -1 as a float data type the if statement is true and runs the code below
        {
            FindObjectOfType<GameManager>().EndGame(); // this code uses the FindObjectType to find our GameManager gameObject defined within the brackets <> and calls it and its EndGame() member/function
        }
    }
}

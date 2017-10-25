using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player; // public variable defined using Transform component of unity that controls movement named player, in unity we can change this because its public its intended purpose is to select the player for following but could be another object
    public Vector3 offset; // public variable using Vector3 data type for a triple numeric value, example  x,y,z, it was made public so we can change it in unity to offset the camera from the player(GameObject) target we set using the player variable
	
	// Update is called once per frame, private and can only be accessed from this script
	void Update () {
        transform.position = player.position + offset; // every frame the object with this script attached will run this function,
    }                                                  //  it uses transform.position from unity to set the position of the gameObject with this script to equal the same as the Targeted gameobject defined in unity
}                                                      //  in this case the players(GameObject) set in unity position + by the defined offset amount in unity editor by our vector3 variable.

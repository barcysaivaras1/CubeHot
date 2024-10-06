using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    //This is used to reference the rigidbody component
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    public float forwardMovement = 20f;
    public float sidewaysMovement = 10f;

    public TimeManager timeManager;

    // Update is called once per frame
    //Use fixedUpdate for anything related to physics
    void FixedUpdate()
    {
        // Add a forward Force
        transform.Translate(Vector3.forward * forwardMovement * Time.fixedDeltaTime);
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            //rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            transform.Translate(Vector3.right * sidewaysMovement * Time.fixedDeltaTime);
        }
        if (Input.GetKey("a"))
        {
            //rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            transform.Translate(Vector3.left * sidewaysMovement * Time.fixedDeltaTime);
        }
        if (Input.GetKey("space"))
        {
            if (FindObjectOfType<ProgressBar>().getProgress() > 0.1)
            {
                FindObjectOfType<ProgressBar>().usingPower(true);
                timeManager.SlowMo();
            }
        }
        else {
            FindObjectOfType<ProgressBar>().usingPower(false);
        }

        if (rb.position.y < -1f) { 
           FindObjectOfType<GameManager>().EndGame();
        }
    }
}

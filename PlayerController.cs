public class PlayerController : MonoBehaviour
{
     void Update()
    {
        CheckKeyPress();
    }

    void CheckKeyPress() {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            Rotate(90);

        else if (Input.GetKeyDown(KeyCode.RightArrow))
            Rotate(-90);

        else if(Input.GetKeyDown(KeyCode.UpArrow))
            Rotate(180);

        else if (Input.GetKeyDown(KeyCode.DownArrow))
            Rotate(-180);
    }

    void Rotate(float z)
    {
        Vector3 currentRotation = transform.eulerAngles;
        Vector3 nextRotation = transform.eulerAngles + new Vector3(0, 0, z);
        transform.eulerAngles = Vector3.Lerp(currentRotation, nextRotation,  1f);
        ChangeColorBasedOnAngle();
    }

      void ChangeColorBasedOnAngle()
    {
        
        if (transform.eulerAngles.z >= 270)
            ChangeColor(Color.green);

        else if (transform.eulerAngles.z >= 180)
            ChangeColor(Color.blue);

        else if (transform.eulerAngles.z >= 90)
            ChangeColor(Color.yellow);

        else if (transform.eulerAngles.z >= 0)
            ChangeColor(Color.red);

    }

     void ChangeColor(Color color)
    {
        GetComponent<SpriteRenderer>().material.color = color;
    }
}
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
}
using UnityEngine;
using System.Collections;

public class RTSCamera : MonoBehaviour {

    private Vector2 rotationSens = new Vector2 (0.3f, -0.3f);
    //public float yRotationSens = -0.5f;
    private Vector2 translationSens = new Vector2(1,1);
    //public float yTranslationSens = 1;

    float zoomSensitivity = 10;


    private bool isRotating = false;
    Vector3 mouseStartPosition;
    Vector3 startRotation;
    // Update is called once per frame
    void Update()
    {
        //listen for BMB

        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (!isRotating)
            {
                isRotating = true;
                mouseStartPosition = Input.mousePosition;
                startRotation = transform.rotation.eulerAngles;
            }
            else
            {
                Vector3 curMousePosition = Input.mousePosition;
                transform.rotation = Quaternion.Euler(new Vector3(startRotation.x + ((curMousePosition.y - mouseStartPosition.y) * rotationSens.y),  ((startRotation.y + (curMousePosition.x - mouseStartPosition.x) * rotationSens.x)), 0));
            }
        }
        else
        {
            isRotating = false;
        }
        transform.Translate(translationSens.x * Input.GetAxis("Horizontal"), translationSens.x * Input.GetAxis("Vertical") * Mathf.Sin(transform.rotation.eulerAngles.x * (3.14f/180)), translationSens.y * Input.GetAxis("Vertical") * Mathf.Cos(transform.rotation.eulerAngles.x * (3.14f / 180)) + (Input.GetAxis("Mouse ScrollWheel") * zoomSensitivity), Space.Self);
    }

}
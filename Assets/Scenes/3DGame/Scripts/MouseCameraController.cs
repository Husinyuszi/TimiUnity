using UnityEngine;

 class MouseCameraController : MonoBehaviour
{
    [SerializeField] CameraController cameraController;

    [SerializeField] float horizontalSensitivity = 1;
    [SerializeField] float verticalSensitivity = 1;
    [SerializeField] bool invertMouseVertical=true;

    [SerializeField] bool disableCursor=true;

     void Start()
    {
        if(disableCursor)
            Cursor.visible= false;
    }


    void Update()
    {
        float mouseMovmentX = Input.GetAxis("Mouse X");
        float mouseMovmentY = Input.GetAxis("Mouse Y");

        cameraController.horizontalAngle += mouseMovmentX*horizontalSensitivity;

        float verticalM=invertMouseVertical? -1 : 1;
        cameraController.verticalAngle -= mouseMovmentY*verticalSensitivity;
    }
}

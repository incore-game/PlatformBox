using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class CameraRotateAround : MonoBehaviour {

	public Transform target;
	public Vector3 offset;
	public float sensitivity = 3; // чувствительность мышки
	public float limit = 80; // ограничение вращения по Y
    public float limit_min = 0; // ограничение вращения по Y
    public float zoom = 0.25f; // чувствительность при увеличении, колесиком мышки
	public float zoomMax = 100; // макс. увеличение
	public float zoomMin = 3; // мин. увеличение
	private float X, Y;

	void Start () 
	{
        UnityEngine.Cursor.visible = true;

        limit = Mathf.Abs(limit);
		if(limit > 360) limit = 360;
		offset = new Vector3(offset.x, offset.y, -Mathf.Abs(zoomMax)/2);
		transform.position = target.position + offset;
	}

	void Update ()
	{

        UnityEngine.Cursor.visible = true;
        if (Input.GetAxis("Mouse ScrollWheel") > 0) offset.z += zoom;
		else if(Input.GetAxis("Mouse ScrollWheel") < 0) offset.z -= zoom;
		offset.z = Mathf.Clamp(offset.z, -Mathf.Abs(zoomMax), -Mathf.Abs(zoomMin));

        float delta_x = CrossPlatformInputManager.GetAxis("Horizontal");

        X -=  (delta_x* System.Math.Abs(delta_x)) * sensitivity;

        float delta_y = CrossPlatformInputManager.GetAxis("Vertical");

        Y -= (delta_y * System.Math.Abs(delta_y)) * sensitivity;
		Y = Mathf.Clamp (Y, -limit, -limit_min);
		transform.localEulerAngles = new Vector3(-Y, X, 0);
		transform.position = transform.localRotation * offset + target.position;
	}
}
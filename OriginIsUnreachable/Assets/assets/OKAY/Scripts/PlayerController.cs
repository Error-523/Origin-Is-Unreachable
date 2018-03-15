using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float TranslateSpeed;
    public float RotationSpeed;

	void Update()
	{
        float x = Input.GetAxis("Horizontal") * RotationSpeed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * TranslateSpeed * Time.deltaTime;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}

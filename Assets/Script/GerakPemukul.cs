using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakPemukul : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;
    private Transform thisTF;
    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        thisTF = GetComponent<Transform>();
    }

    // Update is called once per frame
    private void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        rig.velocity = movement;
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }

    public void ActivatePULarger(float magnitude)
    {
        Vector2 scaleUp = new Vector2(thisTF.localScale.x + 1f, thisTF.localScale.y + 1f);
        thisTF.localScale = scaleUp;
    }

}

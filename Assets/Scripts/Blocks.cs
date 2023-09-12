using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blocks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float prevTime;
    public float fallTime = 0.5f;
    public Vector3 rotPoint;

    // Update is called once per frame
    void Update()
    {
        // Fall
        if (Time.time - prevTime > fallTime)
        {
            transform.position += new Vector3(0, -1, 0);

            if (!ValidMove())
            {
                transform.position -= new Vector3(0, -1, 0);
                AddBlocks();
                this.enabled = false;
                FindObjectOfType<Spawn>().SpawnBlocks();
            }

            prevTime = Time.time;
        }

        // Move Z - Right
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, 0, -1);

            if (!ValidMove())
            {
                transform.position -= new Vector3(0, 0, -1);
            }
        }

        // Move Z - Left
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0, 1);

            if (!ValidMove())
            {
                transform.position -= new Vector3(0, 0, 1);
            }
        }

        // Move X - Right
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0);

            if (!ValidMove())
            {
                transform.position -= new Vector3(1, 0, 0);
            }
        }

        // Move X - Left
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0);

            if (!ValidMove())
            {
                transform.position -= new Vector3(-1, 0, 0);
            }
        }

        // Rotate X
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.RotateAround(transform.TransformPoint(rotPoint), new Vector3(1, 0, 0), 90);

            if (!ValidMove())
            {
                transform.RotateAround(transform.TransformPoint(rotPoint), new Vector3(1, 0, 0), -90);
            }
        }

        // Rotate Y
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.RotateAround(transform.TransformPoint(rotPoint), new Vector3(0, 1, 0), 90);

            if (!ValidMove())
            {
                transform.RotateAround(transform.TransformPoint(rotPoint), new Vector3(0, 1, 0), -90);
            }
        }

        // Rotate X
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.RotateAround(transform.TransformPoint(rotPoint), new Vector3(0, 0, 1), 90);

            if (!ValidMove())
            {
                transform.RotateAround(transform.TransformPoint(rotPoint), new Vector3(0, 0, 1), -90);
            }
        }
    }

    public static int Xgrid = 10;
    public static int Ygrid = 10;
    public static int Zgrid = 10;

    public static Transform[,,] fillGrid = new Transform[Xgrid, Ygrid + 5, Zgrid];

    // Function: Blocks can be move?
    public bool ValidMove()
    {
        foreach (Transform children in transform)
        {
            int Xpos = Mathf.RoundToInt(children.transform.position.x);
            int Ypos = Mathf.RoundToInt(children.transform.position.y);
            int Zpos = Mathf.RoundToInt(children.transform.position.z);

            if (Xpos < 0 || Xpos >= Xgrid || Ypos < 0 || Zpos < 0 || Zpos >= Zgrid)
            {
                return false;
            }

            if (fillGrid[Xpos, Ypos, Zpos] != null)
            {
                return false;
            }
        }

        return true;
    }

    // Function: Add blocks to grid
    void AddBlocks()
    {
        foreach (Transform children in transform)
        {
            int Xpos = Mathf.RoundToInt(children.transform.position.x);
            int Ypos = Mathf.RoundToInt(children.transform.position.y);
            int Zpos = Mathf.RoundToInt(children.transform.position.z);

            fillGrid[Xpos, Ypos, Zpos] = children;
        }
    }
}

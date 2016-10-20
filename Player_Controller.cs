using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb2d;
    public bool action = false;
    //------------------------------
    //Variaveis do menu
    private bool isShowing = false;
    public GameObject menu;
    public int mPosition = 1;
    public Text button1;
    public Text button2;
    public Text button3;
    public Text button4;
    public Text button5;
    public string[] button_array = new string[5];

    // Use this for initialization
    void Start () {

        button_array[0] = button1.text;
        button_array[1] = button2.text;
        button_array[2] = button3.text;
        button_array[3] = button4.text;
        button_array[4] = button5.text;
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        menu = gameObject.GetComponent<GameObject>();
        
    
	}

    void Moviment()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        if(Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if(Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if(Input.GetAxis("Vertical") < 0)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }

    void menu_Controler()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow)&&(mPosition < 5))
        {
            mPosition++;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)&&(mPosition > 1))
        {
            mPosition--;
        }

    }
	
	// Update is called once per frame
	void Update () {

        //Moviment();
        menu_Controler();


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isShowing = !isShowing;
            menu.SetActive(isShowing);
        }    
	}
}

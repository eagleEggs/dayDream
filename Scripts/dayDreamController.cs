using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEditor;

public class dayDreamController : MonoBehaviour {

    private Material shaderPath;
	private string codeString = "hey";
	private string codeString2 = "hey2";
	private string stringToEdit = "hey";
    private TextAsset textFile;
    [SerializeField] private InputField mainInputField;
	private Vector2 scrollPosition;
    [SerializeField] private Button saveButton;
    [SerializeField] private Button loadButton;
    private string text;
    private string text2;
    private string text3;


	// Use this for initialization

	void Start () {

    Button btn2 = loadButton.GetComponent<Button>();
    btn2.onClick.AddListener(ReadString);

    Button btna = saveButton.GetComponent<Button>(); // for some reason this isn't working
    btna.onClick.AddListener(WriteString);
		

	}
	
	// Update is called once per frame

public void ReadString()
    {
        string path2 = "Assets/dayDream/Shaders/dayDreamShader.shader";
        StreamReader reader = new StreamReader(path2); 
        string content = new StreamReader(path2).ReadToEnd();
        string text4 = reader.ReadToEnd();
        text3 = mainInputField.text;
        mainInputField.text =content;
        reader.Close();
    }

public void WriteString()
    {

        string path = "Assets/dayDream/Shaders/dayDreamShader.shader";

        StreamWriter writer = new StreamWriter(path);
        text2 = mainInputField.text;
        writer.WriteLine(text2);
        writer.Close();

		mainInputField.text =text2;
        AssetDatabase.Refresh();

    }       

    void OnGUI()
    {



    }

    void Update(){

        if ((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKeyDown(KeyCode.Z))
        {
            ReadString();
        }
        if ((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKeyDown(KeyCode.X))
        {
            WriteString();
        }
        if ((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKeyDown(KeyCode.R))
        {
            // reload shader to base
        }
        if ((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKeyDown(KeyCode.C))
        {
            // change text color
        }
        if ((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKeyDown(KeyCode.V))
        {
            // change background color
        }
        if ((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKeyDown(KeyCode.B))
        {
            // toggle background
        }
        if ((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKeyDown(KeyCode.D))
        {
            // toggle dayDream
        }



    }


}




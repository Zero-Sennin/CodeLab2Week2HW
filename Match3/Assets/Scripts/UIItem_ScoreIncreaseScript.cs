using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIItem_ScoreIncreaseScript : MonoBehaviour {

    protected GameManagerScript gameManager;

    // Use this for initialization
    void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        Vector3 thePosition = gameManager.scoreText.transform.position;
        thePosition.x += 50f;
        thePosition.y -= 10f;
        thePosition.z = 0f;

        transform.position = thePosition;
        Destroy(gameObject, 5f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * 15 * Time.deltaTime);
	}

    public void SetTextValue(int value)
    {
        GetComponent<Text>().text = "+" + value;
    }
}

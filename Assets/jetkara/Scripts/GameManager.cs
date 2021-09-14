using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject objects;

	public TextMesh scoreLabel;
	public static int score;
	public int Score
	{
		set
		{
			score = value;

			scoreLabel.text = Score.ToString();
		}
		get
		{
			return score;
		}
	}

	void Start () 
	{
		score = 0;

		InvokeRepeating("CreateObjects", 1, 0.1f);
	}

	void CreateObjects()
	{
		Instantiate(objects, new Vector3(7.5f, 0 , 0) , Quaternion.identity);
	}
}

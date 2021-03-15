using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject coin;
    float timer = 0.0f;
    float creatTime = 5.0f;

    static public int score = 0;
    private int bestScore = 0;

    public Text scoreText;
    public GameObject startButton;

    static public bool isPlay = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.0f;
        isPlay = false;

        LoadBestScore();
    }

    public void GamePlay()
    {
        Time.timeScale = 1.0f;
        isPlay = true;
    }

    public void GameStop()
    {
        Time.timeScale = 0.0f;
        startButton.SetActive(true);
        isPlay = false;
    }

    void LoadBestScore()
    {
        bestScore = PlayerPrefs.GetInt("Best Score");
    }

    void SaveBestScore()
    {
        if (bestScore < score)
        {
            bestScore = score;

            PlayerPrefs.SetInt("Best Score", bestScore);
        }
    }

    private void OnApplicationQuit()
    {
        SaveBestScore();
    }

    // Update is called once per frame
    void Update()
    {
        //float t = Time.deltaTime;

        if (timer > creatTime)
        {
            float x = UnityEngine.Random.Range(-10.0f, 10.0f);
            float z = UnityEngine.Random.Range(-10.0f, 10.0f);

            GameObject newCoin = ObjectPool.SharedInstance.GetPooledObject();
            if (newCoin != null)
            {
                newCoin.transform.SetPositionAndRotation(new Vector3(x, 1, z), Quaternion.identity);
                newCoin.SetActive(true);
            }

            timer = 0.0f;
        }

        timer += Time.deltaTime;

        scoreText.text = score.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public enum GAME_STATUS{
        Ready,
        InGame,
        GameOver
    }

    private GAME_STATUS status;

    public GameObject PanelReady;
    public GameObject PanelInGame;
    public GameObject PanelGameOver;
    public PipeLineManager pipeLineManager;
    // Start is called before the first frame update
    void Start()
    {
        this.PanelReady.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
        this.status = GAME_STATUS.InGame;
        UpdateUI();
        pipeLineManager.StartRun();
        Debug.LogFormat("StartGame:{0}",this.status);
    }

    public void UpdateUI(){
        this.PanelReady.SetActive(this.status == GAME_STATUS.Ready);
        this.PanelInGame.SetActive(this.status == GAME_STATUS.InGame);
        this.PanelGameOver.SetActive(this.status == GAME_STATUS.GameOver);
    }
}

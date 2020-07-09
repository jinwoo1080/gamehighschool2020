﻿using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class GameManeger_Dungeon : MonoBehaviour
{
    public Transform m_StartPoint;
    public PlayerControllerDungeon m_Player;

    public Text m_ClearUI;
    public Text m_ScoreUI;

    public void Start()
    {
        GameStart();

    }
    public void GameStart()
    { 
        //출발지점에서 플레이어가 스폰
        m_Player.gameObject.SetActive(true);
        m_Player.transform.position = m_StartPoint.position;
        m_Player.transform.rotation = m_StartPoint.rotation;
        //게임 클리어시 메세지가 보이지 않는다
        m_ClearUI.gameObject.SetActive(false);
        //게임 스코어 메시지가보인다
        m_ClearUI.gameObject.SetActive(true);
    }
    public void GameClear()
    {
        //플레이어가 비활성화된다
        //게임 클리어시 메세지가 보인다
        //게임 스코어 메시지가 보인다
    }
    public void ReturnStartPoint()
    {
        // 플레이어를 출발지점으로 되돌린다
    }
}

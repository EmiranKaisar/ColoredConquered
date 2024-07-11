using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class GroundManager : MonoBehaviour
{
    //Control whole ground

    public int length = 20;
    public int height = 10;

    public GameObject tileObj;

    private GameObject _ground;
    
    //this should be a list of list
    private List<GameObject> _tileObjList = new List<GameObject>();

    private void Start()
    {
        _ground = this.GameObject();
        InitGround();
        
    }

    private void InitGround()
    {
        //loop
          //create tiles
          //assign position
          //assign color
          //give interpretation
          int color = 0;
          for (int i = 0; i < length; i++)
          {
              for (int j = 0; j < height; j++)
              {
                  color = Random.Range(0, 5);
                  CreateTile(new Vector3(i, j, 0), color);
              }
          }
        
    }

    public void CreateTile( Vector3 pos, int color)
    {
        int index = _tileObjList.Count;
        _tileObjList.Add(Instantiate(tileObj, _ground.transform));
        _tileObjList[index].transform.position = pos;
        _tileObjList[index].GetComponent<TileClass>().AddLevel(color);
    }
    
    //for now, we don't need this
    //given index and pos, we can look around its environment then give interpretation
    public void UpdateInterpretation(int index, Vector3 pos)
    {
        
    }
    
}

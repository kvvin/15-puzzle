using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;   

public class numberBox : MonoBehaviour
{

    public int index = 0;
    int x = 0; 
    int y = 0;

    private Action<int, int> swapFunc = null;

    public void Init(int i, int j, int index, Sprite sprite, Action<int, int> swapFunc){
        this.index = index;
        this.GetComponent<SpriteRenderer>().sprite = sprite;
        UpdatePos(i,j);
        this.swapFunc = swapFunc;
    }

    public void UpdatePos(int i, int j){
        x = i;
        y = j;
        StartCoroutine(Move());
    }


    IEnumerator Move()
    {
        float elapseTime = 0;
        float duration = 0.2f;
        Vector2 start = this.gameObject.transform.localPosition;
        Vector2 end = new Vector2(x,y);

        while (elapseTime<duration)
        {
            this.gameObject.transform.localPosition = Vector2.Lerp(start, end, (elapseTime/duration));
            elapseTime += Time.deltaTime;
            yield return null;
        }

        this.gameObject.transform.localPosition = end;
    }
    

    public bool IsEmpty(){
        
        return index == 16;
    }
    
    void OnMouseDown() {
        if(Input.GetMouseButtonDown(0) && swapFunc!=null){
            swapFunc(x,y);
        }
    }

}

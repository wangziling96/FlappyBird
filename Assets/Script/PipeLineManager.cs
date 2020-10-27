using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeLineManager : MonoBehaviour
{
    public GameObject template;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    Coroutine coroutine = null;
    public void StartRun(){
        coroutine = StartCoroutine(GeneratePipeLines());//启动协程
    }

    public void Stop(){
        StopCoroutine(coroutine);
    }

    IEnumerator GeneratePipeLines(){ //协程写法
        while(true){
            GeneratePipeLine();

            yield return new WaitForSeconds(2f);
        }
    }

    void GeneratePipeLine(){
        Instantiate(template,this.transform);//创建对象，对象的父节点
    }
}

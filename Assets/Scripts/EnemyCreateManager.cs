using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreateManager : MonoBehaviour
{   public enum SelectEnemy { Box,Circle,CircleSnake};
    public SelectEnemy enemySelector;
     bool _toLeft = false;
     bool _toRight = false;
     bool _toUp = false;
     bool _toDown = false;

    float _distanceX, _distanceY, _distanceZ;
    public GameObject enemyBox;
    public GameObject enemyCircle;
    Vector3 _enemyStartCoordinate;
    private void Start()
    {
        EnemySelector();
        // EnemyBox();
        // EnemyCircle();
        //EnemyCircleSnake();
    }
   
    private void EnemySelector()
    {
        switch (enemySelector)
        {
            case SelectEnemy.Box:
                EnemyBox();
                break;
            case SelectEnemy.Circle:
                EnemyCircle();

                break;
            case SelectEnemy.CircleSnake:
                EnemyCircleSnake();
                break;
            
        }
    }
    void EnemyBox()
    {
        for (int i = 0; i < 200; i++)
        {
            _enemyStartCoordinate.x = Random.Range(-20f, 20f);
            _enemyStartCoordinate.y = Random.Range(-20f, 20f);
            _enemyStartCoordinate.z = Random.Range(50f, 200f);

            Instantiate(enemyBox, _enemyStartCoordinate, Quaternion.identity);
        }
        for (int i = 0; i < 10; i++)
        {
            
            _enemyStartCoordinate.x = 0;
            _enemyStartCoordinate.y = 0;
            _enemyStartCoordinate.z = Random.Range(50f, 200f);

            Instantiate(enemyBox, _enemyStartCoordinate, Quaternion.identity);

        }




    }
    
    void EnemyCircle()
    {

        
        
        GameObject tutucu;
        int _coordinateSelecter,_dirSelectorX,_dirSelectorY;
        _enemyStartCoordinate.x = Random.Range(-20f, 20f);
        _enemyStartCoordinate.y = Random.Range(-20f, 20f);
        _enemyStartCoordinate.z = Random.Range(50f, 60f);
        
        tutucu = Instantiate(enemyCircle, _enemyStartCoordinate, Quaternion.Euler(90,0,0));
        tutucu.GetComponent<enemy>().speed = 1.5f;
        
        for (int i = 0; i < 50; i++)
        {   _coordinateSelecter= Random.Range(0, 3);
            Debug.Log(_coordinateSelecter);
            switch (_coordinateSelecter)
            { 
                case 0:
                    //sadece x
                    _dirSelectorX = Random.Range(0, 2);
                    tutucu = Instantiate(enemyCircle, new Vector3(tutucu.transform.position.x, tutucu.transform.position.y, tutucu.transform.position.z), Quaternion.Euler(90, 0, 0));

                    if (_dirSelectorX == 0)
                    {//x + yonde
                        tutucu.transform.position = new Vector3(tutucu.transform.position.x+2,tutucu.transform.position.y,tutucu.transform.position.z+15);
                        if(tutucu.transform.position.x > 20)
                        {
                            tutucu.transform.position = new Vector3(tutucu.transform.position.x - 2, tutucu.transform.position.y,tutucu.transform.position.z);

                        }
                    }else if (_dirSelectorX == 1)
                    {//x - yonde
                        tutucu.transform.position =new Vector3(tutucu.transform.position.x - 2, tutucu.transform.position.y, tutucu.transform.position.z + 15);
                        if (tutucu.transform.position.x < -20)
                        {
                            tutucu.transform.position = new Vector3(tutucu.transform.position.x +2, tutucu.transform.position.y, tutucu.transform.position.z);

                        }
                    }
                    tutucu.GetComponent<enemy>().speed = 1.5f;

                    break;
                case 1:
                    //sadece y
                    _dirSelectorY = Random.Range(0, 2);
                    tutucu = Instantiate(enemyCircle, new Vector3(tutucu.transform.position.x, tutucu.transform.position.y , tutucu.transform.position.z), Quaternion.Euler(90, 0, 0));

                    if (_dirSelectorY == 0)
                    {//y + yonde
                        tutucu.transform.position =new Vector3(tutucu.transform.position.x, tutucu.transform.position.y+2, tutucu.transform.position.z + 15);
                        if (tutucu.transform.position.y > 20)
                        {
                            tutucu.transform.position = new Vector3(tutucu.transform.position.x , tutucu.transform.position.y-2, tutucu.transform.position.z);

                        }
                    }
                    else if (_dirSelectorY == 1)
                    {//y - yonde
                        tutucu.transform.position= new Vector3(tutucu.transform.position.x , tutucu.transform.position.y-2, tutucu.transform.position.z + 15);
                        if (tutucu.transform.position.y < -20)
                        {
                            tutucu.transform.position = new Vector3(tutucu.transform.position.x , tutucu.transform.position.y+2, tutucu.transform.position.z);

                        }
                    }
                    tutucu.GetComponent<enemy>().speed = 1.5f;

                    break;
                case 2:
                    //x ve y
                    _dirSelectorX = Random.Range(0, 2);
                    _dirSelectorY= Random.Range(0, 2);
                    tutucu = Instantiate(enemyCircle, new Vector3(tutucu.transform.position.x, tutucu.transform.position.y, tutucu.transform.position.z), Quaternion.Euler(90, 0, 0));

                    if (_dirSelectorX == 0)
                    {//x + yonde
                        tutucu.transform.position = new Vector3(tutucu.transform.position.x + 2, tutucu.transform.position.y, tutucu.transform.position.z + 15);
                        if (tutucu.transform.position.x > 20)
                        {
                            tutucu.transform.position = new Vector3(tutucu.transform.position.x - 2, tutucu.transform.position.y, tutucu.transform.position.z);

                        }
                    }
                    else if (_dirSelectorX == 1)
                    {//x - yonde
                        tutucu.transform.position=new Vector3(tutucu.transform.position.x - 2, tutucu.transform.position.y, tutucu.transform.position.z + 15);
                        if (tutucu.transform.position.x < -20)
                        {
                            tutucu.transform.position = new Vector3(tutucu.transform.position.x +2, tutucu.transform.position.y, tutucu.transform.position.z);

                        }
                    }
                    if (_dirSelectorY == 0)
                    {//y + yonde
                        tutucu.transform.position = new Vector3(tutucu.transform.position.x, tutucu.transform.position.y + 2, tutucu.transform.position.z);
                        if (tutucu.transform.position.y > 20)
                        {
                            tutucu.transform.position = new Vector3(tutucu.transform.position.x, tutucu.transform.position.y - 2, tutucu.transform.position.z);

                        }
                    }
                    else if (_dirSelectorY == 1)
                    {//y - yonde
                        tutucu.transform.position = new Vector3(tutucu.transform.position.x, tutucu.transform.position.y - 2, tutucu.transform.position.z);
                        if (tutucu.transform.position.y < -20)
                        {
                            tutucu.transform.position = new Vector3(tutucu.transform.position.x, tutucu.transform.position.y + 2, tutucu.transform.position.z);

                        }
                    }
                    tutucu.GetComponent<enemy>().speed = 1.5f;

                    break;
                default:
                    break;
            }
            



        }

    }
    void EnemyCircleSnake()
    {
        
            GameObject tutucu;
        int _coordinateSelecter;
          
            _enemyStartCoordinate.x = Random.Range(-20f, 20f);
            _enemyStartCoordinate.y = Random.Range(-20f, 20f);
            _enemyStartCoordinate.z = Random.Range(50f, 60f);

            tutucu = Instantiate(enemyCircle, _enemyStartCoordinate, Quaternion.Euler(90, 0, 0));
            tutucu.GetComponent<enemy>().speed = 1.5f;
       _coordinateSelecter= Random.Range(0, 4);
        switch (_coordinateSelecter)
        {
            case 0:
                _toDown = true;
                _toRight = true;
                break;
            case 1:
                _toDown = true;
                _toLeft = true;
                break;
            case 2:
                _toUp = true;
                _toRight = true;
                break;
            case 3:
                _toUp = true;
                _toLeft = true;
                break;
        }
        for (int i = 0; i < 55; i++)
        {
            tutucu = Instantiate(enemyCircle, new Vector3(tutucu.transform.position.x, tutucu.transform.position.y, tutucu.transform.position.z + 15), Quaternion.Euler(90, 0, 0));
            tutucu.GetComponent<enemy>().speed = 1.5f;
            if (_toRight)
            {//x+
                Debug.Log("x+ calisti");
                tutucu.transform.position = new Vector3(tutucu.transform.position.x + 2, tutucu.transform.position.y, tutucu.transform.position.z);
                if (tutucu.transform.position.x > 20)
                {
                    tutucu.transform.position = new Vector3(tutucu.transform.position.x - 2, tutucu.transform.position.y, tutucu.transform.position.z);
                    _toRight = false;
                    _toLeft = true;
                }
            }
            if (_toLeft)
            { //x-
                Debug.Log("x- calisti");

                tutucu.transform.position = new Vector3(tutucu.transform.position.x - 2, tutucu.transform.position.y, tutucu.transform.position.z);
                if (tutucu.transform.position.x < -20)
                {
                    tutucu.transform.position = new Vector3(tutucu.transform.position.x + 2, tutucu.transform.position.y, tutucu.transform.position.z);
                    _toRight = true;
                    _toLeft = false;
                }
               
            }
            if (_toUp)
            {//y+
                Debug.Log("Y+ calisti");

                tutucu.transform.position = new Vector3(tutucu.transform.position.x, tutucu.transform.position.y+2, tutucu.transform.position.z);
                if (tutucu.transform.position.y > 20)
                {
                    tutucu.transform.position = new Vector3(tutucu.transform.position.x, tutucu.transform.position.y-2, tutucu.transform.position.z);
                    _toUp = false;
                    _toDown = true;
                }

            }
            if (_toDown)
            {//y-
                Debug.Log("Y- calisti");

                tutucu.transform.position = new Vector3(tutucu.transform.position.x, tutucu.transform.position.y - 2, tutucu.transform.position.z);
                if (tutucu.transform.position.y < -20)
                {
                    tutucu.transform.position = new Vector3(tutucu.transform.position.x, tutucu.transform.position.y + 2, tutucu.transform.position.z);
                    _toUp = true;
                    _toDown = false;
                }
            }

        }
        
            

        

    }
    
}

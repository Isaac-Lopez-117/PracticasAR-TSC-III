using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public GameObject ARObject;
    public GameObject objectRotate;

    public float rotateSpeed = 50f;
    bool rotateStatus = false;

    [SerializeField] private Camera aRCamera;
    private bool isARObjectSelected;
    private string tagARObjects = "ARObject";
    private Vector2 initialTouchPos;

    public void rotateIf(){
        if (rotateStatus == false){
            rotateStatus = true;
        }else{
            rotateStatus = false;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0){
            Touch touchOne = Input.GetTouch(0);

            if (Input.touchCount == 1){
                
                if (touchOne.phase == TouchPhase.Began)
                {
                    initialTouchPos = touchOne.position;
                    isARObjectSelected = CheckTouchOnArObject(initialTouchPos);
                    if (isARObjectSelected)
                    {
                        rotateIf();
                    }
                    
                }
                
            }
        }
        if(rotateStatus)
        {
            objectRotate.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }else{
            objectRotate.transform.Rotate(Vector3.up, rotateSpeed * 0);
        }
    }

    private bool CheckTouchOnArObject(Vector2 touchPosition){
        Ray ray = aRCamera.ScreenPointToRay(touchPosition);

        if (Physics.Raycast(ray, out RaycastHit hitARObject)){
            if (hitARObject.collider.CompareTag(tagARObjects)){
                ARObject = hitARObject.transform.gameObject;
                return true;
            }
        }

        return false;
    }
}

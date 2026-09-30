using UnityEngine;
// Unity의 GameObject, Transform, MonoBehaviour 기능을 사용한다.

public class RotateObject : MonoBehaviour
// RotateObject라는 이름의 Unity Component를 만든다.
// 파일 이름도 반드시 RotateObject.cs여야 한다.
{
    [SerializeField]
    // private 변수이지만 Unity Inspector에는 보이게 한다.

    private float rotationSpeed = 45f;
    // rotationSpeed: 회전 속도를 저장하는 변수 이름
    // float: 소수점이 있는 숫자를 저장하는 자료형
    // 45f: 1초에 45도 회전한다는 뜻

    private void Start()
    // Play Mode를 시작할 때 한 번만 실행된다.
    {
        Debug.Log("RotateObject started.");
        // Unity Console에 시작 확인 문장을 한 번 출력한다.
    }

    private void Update()
    // Play Mode가 실행되는 동안 화면이 갱신될 때마다 반복된다.
    {
        transform.Rotate(
            0f,                                  // X축 회전: 0도
            rotationSpeed * Time.deltaTime,      // Y축 회전: 초당 rotationSpeed만큼
            0f                                   // Z축 회전: 0도
        );
        // 이 Script가 붙은 GameObject를 Y축으로 계속 회전시킨다.
        // Time.deltaTime을 곱하면 컴퓨터 속도와 관계없이 비슷한 속도로 회전한다.
    }
}
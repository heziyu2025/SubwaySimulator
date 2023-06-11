using UnityEngine;

public class PathFollow : MonoBehaviour
{
    public Transform[] waypoints;   // 存储路径节点的数组
    public float speed = 0;        // 物体在路径上的移动速度
    public bool loop = false;       // 是否循环移动
    public float acc = 0.5f;

    private int currentWaypoint = 0; // 当前路径节点的索引

    void Update()
    {
        if (currentWaypoint < waypoints.Length)
        {
            // 计算物体在当前节点和下一个节点之间的插值位置
            Vector3 targetPosition = waypoints[currentWaypoint].position;
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);

            // 当物体接近当前节点时，切换到下一个节点
            if (Vector3.Distance(transform.position, targetPosition) < 2)
            {
                currentWaypoint++;
            }

            // 如果已经到达路径的最后一个节点，并且循环标志为真，则重置索引从头开始
            if (currentWaypoint >= waypoints.Length)
            {
                if (loop)
                {
                    currentWaypoint = 0;
                }
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            speed += acc / 1000;
        }
        else
        {
            speed *= 0.99f;
        }
    }
}

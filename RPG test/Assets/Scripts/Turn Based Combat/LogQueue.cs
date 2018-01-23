using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogQueue {

    public string[] queueArray = new string[6];
    public int front = -1;
    public int rear = -1;

    public bool IsEmpty()
    {
        if (front == -1 & rear == -1)
        {
            return true;
        }
        return false;
    }

    public bool isFull()
    {
        if (rear == front)
        {
            return true;
        }
        return false;
    }

    public void Enqueue(string x)
    {
        if ((rear + 1) % 6 == front)
        {
            return;
        }
        else if (IsEmpty() == true)
        {
            front = 0;
            rear = 0;
        }
        else
        {
            rear = (rear + 1) % 6;
        }
        queueArray[rear] = x;
    }

    public void Dequeue()
    {
        if (IsEmpty() == true)
        {
            return;
        }
        else if (front == rear)
        {
            queueArray[front] = "...";
            front = -1;
            rear = -1;
        }
        else
        {
            queueArray[front] = "...";
            front = (front + 1) % 6;
        }
    }
}

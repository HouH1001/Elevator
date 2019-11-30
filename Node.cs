using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node<T>//单链表结点类,采用泛型
{
    private T data; //数据域,当前结点的数据  
    private Node<T> next; //引用域,即下一结点  
    public Node(T item, Node<T> p)
    {
        data = item;
        next = p;
    }
    public Node(Node<T> p)
    {
        next = p;
    }
    public Node()
    {
        data = default(T);
        next = null;
    }
    public T Data;
    public Node<T> Next;
}

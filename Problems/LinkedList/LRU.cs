public class Solution
{

    private static Dictionary<int, Node> _hm;
    private static Node _head;
    private static Node _tail;
    private static int _capacity;

    public Solution(int capacity)
    {
        _head = null;
        _tail = null;
        _capacity = capacity;
        _hm = new Dictionary<int, Node>();
    }

    public int get(int key)
    {
        if (_hm.ContainsKey(key) == false)
        {
            return -1;
        }
        Node del = _hm[key];
        DeleteNode(del);
        Insert(key, del.value);
        return _hm[key].value;
    }

    public void set(int key, int value)
    {
        if (_hm.ContainsKey(key))
        {
            DeleteNode(_hm[key]);
        }

        else if (_hm.Count == _capacity)
        {
            DeleteNode(_head);
        }

        Insert(key, value);
    }

    private static void Insert(int key, int value)
    {
        Node node = new Node(key, value);
        if (_head == null)
        {
            _head = node;
            _tail = node;
        }
        else
        {
            node.prev = _tail;
            _tail.next = node;
            _tail = _tail.next;
        }
        _hm.Add(key, node);
    }

    private static void DeleteNode(Node del)
    {
        if (del == _head)
        {
            if (_hm.Count >= 2)
            {
                _head = _head.next;
                _head.prev = null;
            }
            else
            {
                _head = null; _tail = null;
            }
        }

        else if (del == _tail)
        {
            _tail = _tail.prev;
            _tail.next = null;
        }
        else
        {
            if (del.prev != null) del.prev.next = del.next;
            if (del.next != null) del.next.prev = del.prev;
        }
        _hm.Remove(del.key);
    }
}

class Node
{
    public int key;
    public int value;
    public Node next;
    public Node prev;

    public Node(int key, int value)
    {
        this.key = key;
        this.value = value;
        this.next = null;
        this.prev = null;
    }
}

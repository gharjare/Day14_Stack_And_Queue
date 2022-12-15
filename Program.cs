namespace DsaStackAndQueue
{
    class program
    {
        public static void Main(string[] args)
        {
            StackOperation list = new StackOperation();
            list.Push(56);
            list.Push(30);
            list.Push(70);
            list.Display();

            PeekOperation list1 = new PeekOperation();
            list1.Push(56);
            list1.Push(30);
            list1.Push(70);
            list1.Display();
            list1.Peek();
            list1.Pop();


            QueueOperation queue = new QueueOperation();
            queue.insert(56);
            queue.insert(30);
            queue.insert(70);
            queue.Display();

            DequeOperation deque = new DequeOperation();
            deque.Dequeue(56);
            deque.Dequeue(30);
            deque.Dequeue(70);
            deque.Display();





        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Task
{
    /// <summary>
    /// 文字を表示する実装
    /// </summary>
    class CharDisplayImpl : IDisplay
    {
        private char _head;
        private char _body;
        private char _foot;

        public CharDisplayImpl(char head, char body, char foot)
        {
            _head = head;
            _body = body;
            _foot = foot;
        }

        public void Open()
        {
            Console.Write(_head);
        }

        public void Print()
        {
            Console.Write(_body);
        }

        public void Close()
        {
            Console.WriteLine(_foot);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    /// <summary>
    /// 文字列を表示
    /// </summary>
    public class StringDisplay : IDisplay
    {
        /// <summary>
        /// メッセージ
        /// </summary>
        private readonly String _message;

        /// <summary>
        /// メッセージのバイト文字数
        /// </summary>
        private readonly int _width;

        public StringDisplay(String message)
        {
            var utf8 = Encoding.UTF8;

            _message = message;
            _width = utf8.GetByteCount(message);
        }

        public void Open()
        {
            PrintLine();
        }

        public void Print()
        {
            Console.WriteLine($"|{_message}|");
        }

        public void Close()
        {
            PrintLine();
        }

        /// <summary>
        /// メッセージの長さに合わせた区切り線を表示
        /// </summary>
        private void PrintLine()
        {
            Console.Write("+");
            for(int i = 0; i < _width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");


            new ArrayList();
        }
    }
}

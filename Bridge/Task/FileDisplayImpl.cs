using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bridge.Task
{
    /// <summary>
    /// テキストファイル上の内容を表示する
    /// </summary>
    class FileDisplayImpl : IDisplay
    {
        /// <summary>
        /// テキストファイルのパス
        /// </summary>
        String _filePath;
        StreamReader _streamReader;

        public FileDisplayImpl(String filePath)
        {
            _filePath = filePath;
        }

        public void Open()
        {
            Console.WriteLine("---------------------------------");
        }

        public void Print()
        {
            foreach (var line in File.ReadLines(_filePath))
            {
                Console.WriteLine(line);
            }
        }

        public void Close()
        {
            Console.WriteLine("---------------------------------");
        }
    }
}

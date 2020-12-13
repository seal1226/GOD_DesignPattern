namespace Bridge
{
    /// <summary>
    /// 表示するという機能の最上位クラス
    /// </summary>
    public class Display
    {
        /// <summary>
        /// 実装
        /// </summary>
        private readonly IDisplay _impl;
        
        public Display(IDisplay impl)
        {
            _impl = impl;
        }

        /// <summary>
        /// 出力前処理
        /// </summary>
        public void Open()
        {
            _impl.Open();
        }

        /// <summary>
        /// 出力
        /// </summary>
        public void Print()
        {
            _impl.Print();
        }
  
        /// <summary>
        /// 出力後処理
        /// </summary>
        public void Close()
        {
            _impl.Close();
        }

        /// <summary>
        /// 表示
        /// </summary>
        public void Disp()
        {
            Open();
            Print();
            Close();
        }
    }
}

namespace Bridge
{
    /// <summary>
    /// Displayクラスに複数回表示する機能を追加
    /// </summary>
    public class CountDisplay : Display
    {
        public CountDisplay(IDisplay impl) : base(impl)
        {
            ;
        }

        /// <summary>
        /// 複数表示
        /// </summary>
        /// <param name="count">表示回数</param>
        public void MultiDisp(int count)
        {
            Open();
            for (int i=0; i<count; i++)
            {
                Print();
            }
            Close();
        }
    }
}

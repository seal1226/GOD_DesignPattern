namespace Bridge
{
    /// <summary>
    /// 表示する
    /// </summary>
    public interface IDisplay
    {
        /// <summary>
        /// 出力前処理
        /// </summary>
        void Open();

        /// <summary>
        /// 出力
        /// </summary>
        void Print();

        /// <summary>
        /// 出力後処理
        /// </summary>
        void Close();
    }
}

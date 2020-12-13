using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Task
{
    /// <summary>
    /// 課題1
    /// ランダム回数表示する「機能」を追加したクラス
    /// </summary>
    class RandomDisplay : CountDisplay
    {
        public RandomDisplay(IDisplay impl) : base(impl)
        {
            ;
        }

        /// <summary>
        /// 1以上～指定回数以内表示
        /// </summary>
        /// <param name="max">表示する最大値</param>
        public void RandomDisp(int max)
        {
            MultiDisp(new Random().Next(1,  max)) ;
        }
    }
}

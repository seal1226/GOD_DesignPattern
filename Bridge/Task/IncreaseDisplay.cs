using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Task
{
    /// <summary>
    /// 徐々に表示数を増やして表示する
    /// </summary>
    class IncreaseDisplay : CountDisplay
    {
        public IncreaseDisplay(IDisplay impl) : base(impl)
        {
            ;
        }


        /// <summary>
        /// 指定数文増加する表示
        /// </summary>
        /// <param name="level">指定数</param>
        public void IncreaseDisp(int level)
        {
            int count = 0;
            for (int i = 0; i < level; i++)
            {
                MultiDisp(count);
                count++;
            }
        }
    }
}

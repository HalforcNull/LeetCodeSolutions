using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution365
    {
        /*  http://www.cnblogs.com/grandyang/p/5628836.html
         *  这道问题其实可以转换为有一个很大的容器，我们有两个杯子，容量分别为x和y，
         *  问我们通过用两个杯子往里倒水，和往出舀水，问能不能使容器中的水刚好为z升。
         *  那么我们可以用一个公式来表达：
            z = m * x + n * y

            其中m，n为舀水和倒水的次数，正数表示往里舀水，负数表示往外倒水，那么题目
            中的例子可以写成: 4 = (-2) * 3 + 2 * 5，即3升的水罐往外倒了两次水，5升水
            罐往里舀了两次水。那么问题就变成了对于任意给定的x,y,z，存不存在m和n使得上面
            的等式成立。根据裴蜀定理，ax + by = d的解为 d = gcd(x, y)，那么我们只要只
            要z % d == 0，上面的等式就有解，所以问题就迎刃而解了，我们只要看z是不是x和y
            的最大公约数的倍数就行了，别忘了还有个限制条件x + y >= z，因为x和y不可能称出
            比它们之和还多的水.
         */
        public bool CanMeasureWater(int x, int y, int z)
        {
            if (z == 0)
            { return true; }

            return (x + y >= z) && (z % gcd(x, y) == 0);
        }

        public int gcd(int x, int y)
        {
            if (y == 0)
            { return x; }

            return gcd(y, x % y);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution452
    {
        public int FindMinArrowShots(int[,] points)
        {
            if(points == null || points.GetLength(0) == 0)
            { return 0; }

            List<Point> PointsList = initPoints(points);
            PointsList = PointsList.OrderBy(p => p.Start).ThenBy(p => p.End).ToList();

            int shootCount = 1;
            int shootPos = PointsList[0].End;
            for(int i = 1; i < PointsList.Count; i++)
            {
                if (PointsList[i].Start <= shootPos)
                {
                    shootPos = Math.Min(PointsList[i].End, shootPos);
                }
                else
                {
                    shootCount++;
                    shootPos = PointsList[i].End;
                }
            }


            return shootCount;
        }

        private List<Point> initPoints(int[,] points)
        {
            List<Point> output = new List<Point>();
            for(int i = 0; i < points.GetLength(0); i++)
            {
                output.Add(new Point(points[i, 0], points[i, 1]));
            }

            return output;
        }

        #region My Trash Code

        //public int FindMinArrowShots(int[,] points)
        //{
        //    int balloonCount = points.GetLength(0);
        //    if(balloonCount == 0)
        //    {
        //        return 0;
        //    }
        //    bool[] ExistBalloon = Enumerable.Repeat(true, balloonCount).ToArray();

        //    return ShootAndCount(points, ExistBalloon);
        //}

        //private int ShootAndCount(int[,] points, bool[] existBalloon)
        //{
        //    int firstExist = existBalloon.ToList().FindIndex(t => t == true);
        //    int start = points[firstExist, 0];
        //    int end = points[firstExist, 1];
        //    int minShoot = -1;
        //    for ( int i = start; i <= end; i++)
        //    {
        //        bool[] BalloonAfterShoot;
        //        bool MoreExist = AnyExistAfterShoot(points, existBalloon, i, out BalloonAfterShoot);
        //        int currentShootCount;
        //        if(MoreExist)
        //        { currentShootCount =  ShootAndCount(points, BalloonAfterShoot) + 1 ; }
        //        else
        //        { currentShootCount = 1; }

        //        if(minShoot < 0)
        //        { minShoot = currentShootCount; }
        //        else
        //        { minShoot = Math.Min(minShoot, currentShootCount); }

        //        if(minShoot == 1)
        //        {
        //            return 1;
        //        }
        //    }
        //    return minShoot;
        //}

        //public bool AnyExistAfterShoot(int[,] points, bool[] ExistBeforeShoot, int shoot, out bool[] ExistAfterShoot)
        //{
        //    bool AnyExist = false;
        //    ExistAfterShoot = Enumerable.Repeat(false, ExistBeforeShoot.Length).ToArray();

        //    for(int i = 0; i < points.GetLength(0); i++)
        //    {
        //        if(!ExistBeforeShoot[i])
        //        { continue; }

        //        if(points[i,0] > shoot || shoot > points[i,1])
        //        {
        //            //Exist, not get hit
        //            ExistAfterShoot[i] = true;
        //            AnyExist = true;
        //            continue;
        //        }

        //        //Exist, is hit by the shoot
        //        //Since ExistAfterShoot default value is false;
        //        //We don't need set ExistAfterShoot[i] to false when 'i' is hit
        //    }

        //    return AnyExist;
        //}
        #endregion


    }

    public class Point
    {
        public int Start { get; set; }
        public int End { get; set; }
        public Point(int x, int y)
        {
            Start = x;
            End = y;
        }
    }
}

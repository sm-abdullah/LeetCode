using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCoding.Problems.Mediume
{
    //https://leetcode.com/problems/meeting-rooms-ii/submissions/
    /// <summary>
    /// 04-Oct-2019
    /// </summary>
    public class MeetingRoom2
    {
        public int MinMeetingRooms(int[][] ints)
        {
            Array.Sort(ints, (item2, item1) => {
                if (item2[0] == item1[0])
                {
                    return item2[1].CompareTo(item1[1]);
                }
                return item2[0].CompareTo(item1[0]);

            });
            if (ints == null) return 0;
            if (ints.Length < 2) return ints.Length;
            var pq = new PQ();
            pq.Enqueue(ints[0][1], ints[0]);
            for (int i = 1; i < ints.Length; i++)
            {
                if (pq.Peek()[1] <= ints[i][0])
                {
                    var item = pq.Dequeue();
                }
                pq.Enqueue(ints[i][1], ints[i]);
            }
            return pq.Count;
        }
    }

    internal class PQ
    {
        private SortedDictionary<int, Queue<int[]>> dic = new SortedDictionary<int, Queue<int[]>>();
        public int Count { get; private set; }
        public void Enqueue(int index, int[] item)
        {
            if (!dic.ContainsKey(index))
            {
                dic.Add(index, new Queue<int[]>());
            }
            dic[index].Enqueue(item);
            Count++;
        }
        public int[] Peek()
        {
            if (dic.Count > 0)
            {
                var ee = dic.GetEnumerator();
                ee.MoveNext();
                return ee.Current.Value.Peek();
            }
            return null;
        }
        public int[] Dequeue()
        {
            if (dic.Count > 0)
            {
                var ee = dic.GetEnumerator();
                ee.MoveNext();
                var ret = dic[ee.Current.Key].Dequeue();
                if (dic[ee.Current.Key].Count == 0)
                {
                    dic.Remove(ee.Current.Key);
                }
                Count--;
                return ret;
            }
            return null;
        }
    }
}

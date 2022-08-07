namespace DAL
{
    public class Tools<T> where T : class
    {
        public static bool CheckListExist(List<T> outer, List<T> inner)
        {
            foreach (var item in inner)
            {
                if (!outer.Contains(item))
                {
                    return false;
                }
            }
            return true;
        }
        public static List<T> FindCommon(List<List<T>> lists)
        {
            List<T> minCount = lists.ElementAt(0);
            for (int i = 0; i < lists.Count; i++)
            {
                if (lists.ElementAt(i).Count< minCount.Count)
                {
                    minCount = lists.ElementAt(i);
                }
            }
            var common = new List<T>();
            common.AddRange(minCount);
            lists.Remove(minCount);
            foreach (var list in lists)
            {
                for (int i = 0; i < common.Count; i++)
                {
                    if (!list.Contains(common.ElementAt(i)))
                    {
                        common.RemoveAt(i);
                        if (common.Count == 0)
                        {
                            common = null;
                            break;
                        }
                    }
                }
                
                if (common==null)
                {
                    break;
                }
            }
            return common;


        }
        
    }


}

namespace Common
{
    public static class Test
    {
        public static IEnumerable<List<T>> Combination<T>(this IList<T> self, System.SByte n)
        {
            return Enumerable.Range(0, n - 1)
                .Aggregate(
                    Enumerable.Range(0, self.Count - n + 1)
                        .Select(num => new List<System.SByte> { (System.SByte)num }),
                    (list, _) => list.SelectMany(
                        c =>
                            Enumerable.Range(c.Max() + 1, self.Count - c.Max() - 1)
                                .Select(num => new List<System.SByte>(c) { (System.SByte)num })
                    )
                )
                .Select(
                    c => c
                        .Select(num => self[num])
                        .ToList()
                );
        }
    }


}

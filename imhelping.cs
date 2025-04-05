public static class IMHelping {

	public enum Direction
	{
		Forwards,
		Backwards,
	}

    /*
    Iterate over a list either forwards or backwards in one handy method
    */
	public static IEnumerable<T> Iterate<T>(this IList<T> list, Direction direction = Direction.Forwards)
	{
		for (int i = direction == Direction.Forwards ? 0 : list.Count - 1;
			direction == Direction.Forwards ? i < list.Count : i >= 0;
			i += direction == Direction.Forwards ? 1 : -1) {
			yield return list[i];
		}
	}
}
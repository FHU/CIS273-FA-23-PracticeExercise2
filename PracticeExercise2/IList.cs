using System;
namespace PracticeExercise2
{
	public interface IList<T>
	{

		T Get(int index);

		void Append(T item);
		void Prepend(T item);

		void InsertAfter(T newItem, T existingItem);
		void InsertAt(T item, int index);

		void Remove(T item);
		void RemoveAt(int index);

		T? First { get; }
		T? Last { get; }

		bool IsEmpty { get; }
		int Length { get; }

		int FirstIndexOf(T item);
		bool Contains(T item);

		void Clear();
		IList<T> Reverse();

	}
}


using System;

public class CustomArrayList<T>
{
	private T[] arr;
	private int count;
	
	// Returns the actual list length
	public int Count
	{
		get{ return this.count; }
	}
	
	private const int INITIAL_CAPACITY = 4;
	
	// Initializes the array-based list – allocate memory
	public CustomArrayList(int capacity = INITIAL_CAPACITY)
	{
		this.arr = new T[capacity];
		this.count = 0;
	}
	
	// Adds element to the list
	// It takes the element you want to add as argument
	public void Add(T item)
	{
		GrowIfArrIsFull();
		this.arr[this.count] = item;
		this.count++;
	}
	
	// Inserts the specified element at given position in this list
	// It takes the element to be inserted and the index at which the specified element is to be inserted as arguments
	// It checks for invalid index
	public void Insert(int index, T item)
	{
		if(index > this.count || index < 0)
		{
			throw new IndexOutOfRangeException("Invalid index: " + index);
		}
		GrowIfArrIsFull();
		Array.Copy(this.arr, index, this.arr, index + 1, this.count - index); 
		this.arr[index] = item;
		this.count++;
		
	}
	
	// <summary>
	// Doubles the size of this.arr (grow) if it is full
	// </summary>
	private void GrowIfArrIsFull()
	{
		if(this.count + 1 > this.arr.Length)
		{
			T[] extendedArr = new T[this.arr.Length * 2];
			Array.Copy(this.arr, extendedArr, this.count);
			this.arr = extendedArr;
		}
	}
	
	// <summary>Clears the list (remove everything)</summary>
	public void Clear()
	{
		this.arr = new T[INITIAL_CAPACITY];
		this.count = 0;
	}
	
	// <summary>
	// Returns the index of the first occurrence of the specified
	// element in this list (or -1 if it does not exist).
	// </summary>
	// <param name="item">The element you are searching</param>
	// <returns>
	// The index of a given element or -1 if it is not found
	// </returns>
	public int IndexOf(T item)
	{
		for(int i = 0; i < this.arr.Length; i++)
		{
			if(object.Equals(item, this.arr[i]))
			{
				return i;
			}
		}
		return -1;
	}
	
	// <summary>Checks if an element exists</summary>
	// <param name="item">The item to be checked</param>
	// <returns>If the item exists</returns>
	public bool Contains(T item)
	{
		int index = IndexOf(item);
		bool found = (index != -1);
		return found;
	}
	
	// <summary>Indexer: access to element at given index</summary>
	// <param name="index">Index of the element</param>
	// <returns>The element at the specified position</returns>
	public T this[int index]
	{
		get
		{
			if(index >= this.count || index < 0)
			{
				throw new ArgumentOutOfRangeException("Invalid index: " + index);
			}
			return this.arr[index];
		}
		
		set
		{
			if(index >= this.count || index < 0)
			{
				throw new ArgumentOutOfRangeException("Invalid index: " + index);
			}
			this.arr[index] = value;
		}
	}
	
	// <summary>Removes the element at the specified index
	// </summary>
	// <param name="index">The index of the element to remove
	// </param>
	// <returns>The removed element</returns>
	public T RemoveAt(int index)
	{
		if(index >= this.count || index < 0)
		{
			throw new ArgumentOutOfRangeException("Invalid index: " + index);
		}
		
		T item = this.arr[index];
		Array.Copy(this.arr, index + 1, this.arr, index, this.count - index - 1);
		this.arr[this.count - 1] = default(T);
		this.count--;
		return item;
	}
	
	// <summary>Removes the specified item</summary>
	// <param name="item">The item to be removed</param>
	// <returns>The removed item's index or -1 if the item does not exist</returns>
	public int Remove(T item)
	{
		int index = IndexOf(item);
		if(index != -1)
		{
			this.RemoveAt(index);
		}
		return index;
	}	
	
}
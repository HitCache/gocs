using System;

namespace Lazlo.Gocs
{
	/// <summary>
	/// Represents an event with arguments.
	/// Events support assigning handlers and invoking from anywhere. 
	/// </summary>
	/// <remarks>
	/// Use an arguments struct or class if you need to pass multiple arguments.
	/// </remarks>
	/// <typeparam name="TArgs">The type of argument.</typeparam>
	/// <seealso cref="Event"/>
	public interface IEvent<TArgs> : IEmittedEvent<TArgs>, IHandledEvent<TArgs>
	{
		
	}
	
	/// <summary>
	/// Represents an event with arguments.
	/// IEmittedEvent support assigning handlers from anywhere, but cannot be invoked by external sources.
	/// </summary>
	/// <remarks>
	/// Use an arguments struct or class if you need to pass multiple arguments.
	/// </remarks>
	/// <typeparam name="TArgs">The type of argument.</typeparam>
	/// <seealso cref="Event"/>
	public interface IEmittedEvent<TArgs>
	{
		void AddHandler(Action<TArgs> handler);
		void RemoveHandler(Action<TArgs> handler);
	}
	
	/// <summary>
	/// Represents an event with arguments.
	/// IHandledEvent support invoking by external sources, but are only handled internally by the event owner.
	/// </summary>
	/// <remarks>
	/// Use an arguments struct or class if you need to pass multiple arguments.
	/// </remarks>
	/// <typeparam name="TArgs">The type of argument.</typeparam>
	/// <seealso cref="Event"/>
	public interface IHandledEvent<TArgs>
	{
		void Invoke(TArgs args);
	}
}
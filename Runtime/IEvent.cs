using System;

namespace Lazlo.Gocs
{
	/// <summary>
	/// Represents an event without arguments.
	/// Events support assigning handlers and invoking from anywhere. 
	/// </summary>
	/// <seealso cref="Event{TArgs}"/>
	public interface IEvent : IEmittedEvent, IHandledEvent
	{
		
	}
	
	/// <summary>
	/// Represents an event without arguments.
	/// IEmittedEvent support assigning handlers from anywhere, but cannot be invoked by external sources.
	/// </summary>
	/// <seealso cref="Event{TArgs}"/>
	public interface IEmittedEvent
	{
		void AddHandler(Action handler);
		void RemoveHandler(Action handler);
	}
	
	/// <summary>
	/// Represents an event without arguments.
	/// IHandledEvent support invoking by external sources, but are only handled internally by the event owner.
	/// Events support assigning handlers and invoking from anywhere. 
	/// </summary>
	/// <seealso cref="Event{TArgs}"/>
	public interface IHandledEvent
	{
		void Invoke();
	}
}
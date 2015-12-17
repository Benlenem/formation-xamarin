using System;
using System.Reactive.Linq;
using System.Reactive.Disposables;
using System.Diagnostics;
using System.Reactive.Subjects;

namespace Tutos
{
	public class Rx
	{
		public Rx ()
		{
			//One value
			Observable.Return<string> ("Value").Subscribe (s => {
				Console.WriteLine (s);
			});

			//Empty
			Observable.Empty<string> ().Subscribe (s => {
			}, () => {
				Console.WriteLine ("Completed");
			});


			//Multiple values
			Observable.Create<string> (
				(IObserver<string> observer) => {
					observer.OnNext ("a");
					observer.OnNext ("b");
					observer.OnCompleted ();
					return Disposable.Empty;
				}).Subscribe (s => {
				Console.WriteLine (s);
			});


			//Error
			Observable.Create<string> (
				(IObserver<string> observer) => {
					observer.OnNext ("a");
					observer.OnError (new Exception ("Oups"));
					return Disposable.Empty;
				}).Subscribe (s => {
				Console.WriteLine (s);
			}, ex => {
				Console.WriteLine ("Error : " + ex.Message);
			});
			

			//Using WHERE operator
			Observable.Range (0, 10)
				.Where (i => i % 2 == 0)
				.Subscribe (
					i => Console.WriteLine(i), 
				() => Console.WriteLine ("Completed"));
		

			//Using ALL operator
			var subject = new Subject<int>();
			subject.Subscribe(Console.WriteLine, () => Console.WriteLine("Subject completed"));

			var all = subject.All(i => i < 5);
			all.Subscribe(b => Console.WriteLine("Are all values less than 5? {0}", b));

			subject.OnNext(1);
			subject.OnNext(2);
			subject.OnNext(6);
			subject.OnNext(2);
			subject.OnNext(1);
			subject.OnCompleted();

			//Using CONTAINS operator
			var subject2 = new Subject<int>();
			subject2.Subscribe(
				Console.WriteLine, 
				() => Console.WriteLine("Subject completed"));
			var contains = subject2.Contains(2);
			contains.Subscribe(
				b => Console.WriteLine("Contains the value 2? {0}", b),
				() => Console.WriteLine("contains completed"));
			subject2.OnNext(1);
			subject2.OnNext(2);
			subject2.OnNext(3);
			subject2.OnCompleted();

			//Using COUNT operator
			var numbers = Observable.Range(0,3);

			numbers.Count ().Subscribe (
				c => Console.WriteLine (c + " objects in sequence")
			);

			//Using SELECT operator
			var source = Observable.Range(0, 5);

			source.Select(i=>i+10).Subscribe(
				nb => Console.WriteLine(nb));
			
			//Using SELECT MANY operator
			var source2 = Observable.Range(1,3);

			source2.SelectMany(i=>Observable.Range(1, i)).Subscribe(
				nb => Console.WriteLine(nb));

			//USing DO operator

			int counter = 0;

			Observable.Range (1, 3).Do (
				i => counter += i).Subscribe (next => {
			}, () => Console.WriteLine ("Counter : " + counter)); 
		}
	}
}


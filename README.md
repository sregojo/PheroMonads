# PheroMonads

![](https://logo.png)


This repository contains PheroMonads "core".

What?
====

PheroMonads is a set of the three principal Monads implemented in .NET Core.
* Try Monad
* Maybe Monad
* Either Monad

it allows to simply connect and pipelining different functions in a fluent/functional fashion.

It is FREE!!

More information
====
The main intention of this library is to improve the syntax of the programms using it over being complaiant with the monad mathematical concept.
So if you are looking for cleanness and fluencyness this is your library.

Getting started
====
The intention of PheroMonads is enabling you to define your application flow fluently.
Lets say you have a program that reads some data, processes it and then save the result somewhere.
You can define it in terms of monads so it would look like:


```csharp
public class Error { }
public class ReadData { }
public class ProcessedData { }
public class SavedData { }

static IEither<Error, ReadData> GetData() { }
static IEither<Error, ProcessedData> ProcessData(ReadData d) { }
static IMaybe<Error> SaveData(ProcessedData d) { }
static void PrintError(Error e) { }
static void PrintSuccess() { }
static void PrintException(Exception e) { }

static void Main()
{
	var program =
		Try.Run(() =>
		   GetData().Right(
			   (data) => ProcessData(data).Right(
				   (processedData) => SaveData(processedData)))
		   .Some((error) => PrintError(error)));

	program.Case(success: () => PrintSuccess(), failure: (ex) => PrintException(ex));
}
```

Even usually you only need to focus in the general flow, you can control any branch in the flow using the case operator:

```csharp
var program =
	Try.Run(() =>
	   GetData().Case(
		   right: (data) => ProcessData(data).Case(
			   right: (processedData) => SaveData(processedData)
				.Some((savingError) => PrintError(savingError)),
			   left: (processingError) => PrintError(processingError)),
		   left: (gettingError) => PrintError(gettingError)));
```


License
====
The license is not yet defined.

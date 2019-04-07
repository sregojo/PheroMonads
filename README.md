# PheroMonads

![](https://raw.githubusercontent.com/sregojo/PheroMonads/master/artwork/logo.png)


This repository contains PheroMonads "core".

What?
====

PheroMonads is a set of the three principal Monads implemented in .NET Core.
* Try Monad
* Maybe Monad
* Either Monad

It allows to simply connect and pipelining different functions in a fluent/functional fashion.
It is lightweight and has no dependencies.

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
Try:
====
The try monad will execute the lambda pased as parameter in the Run method.
You can evaluate the result using the .Case() method, so you can control what to execute next in case of an exception or the labmda finished without exception.
You can also focus in the specific results you want using the .Success() or the .Failure() methods.
```csharp
var program = Try.Run(() => GetData());

program.Case(success: (data) => DoSomeThingWith(data), failure: (ex) => DoSomeThingWith(ex));
```
or
```csharp
var program = Try.Run(() => GetData());

program.Success((data) => DoSomeThingWith(data));
```
or
```csharp
var program = Try.Run(() => GetData());

program.Failure((ex) => DoSomeThingWith(ex));
```

Either:
====
For creating an either monad you use the static method Either.Create()
```csharp
var value = new A();
var result = Either.Create<A, B>(value);
```
or
```csharp
var value = new B();
var result = Either.Create<A, B>(value);
```
So you get an Either monad set to the Left or Right operand
You use the Case(), Right() or Left() methods of the returning monad to bind the next lambdas to execute.
```csharp
	   GetData().Case(
		   right: (data) => ProcessData(data),
		   left: (error) => PrintError(error));
```
or
```csharp
	   GetData().Right((data) => ProcessData(data));
```
or
```csharp
	   GetData().Left((error) => PrintError(error));
```
Usually either helps when your method must return two different types at runtime:
```csharp
	if(SomeCondition())
	{
		var mainData = GetData();
		return Either.Create(data);
	}
	
	var alternativeData = GetSomeOtherData();
	return Either.Create(alternativeData);
```

Maybe:
====
For creating a Maybe Monad you can use the Maybe.None() or the Maybe.Some() methods.
```csharp
	var value = new A();
	var result = Maybe.Some(value);
```
or
```csharp
	var result = Maybe.None<A>();
```
usually maybe should replace a return null or an exception thrown when some condition avoid to return the expected data.
```csharp
	if(SomeCondition())
	{
		return Maybe.Some(data);
	}
	
	return Maybe.None();
```

License
====
The license is not yet defined.

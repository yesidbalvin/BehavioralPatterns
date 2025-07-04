## Behavioral Patters

This repository contains implementation of some behavioral patterns, according to this

`https://refactoring.guru/design-patterns/behavioral-patterns `


To create the same solution the following commands can be used.

```
dotnet new sln -n BehavioralPatternsPoC

dotnet new console -n StrategyPattern
dotnet new console -n ObserverPattern
dotnet new console -n CommandPattern
dotnet new console -n ChainOfResponsibilityPattern

dotnet sln BehavioralPatternsPoC.sln add StrategyPattern/StrategyPattern.csproj
dotnet sln BehavioralPatternsPoC.sln add ObserverPattern/ObserverPattern.csproj
dotnet sln BehavioralPatternsPoC.sln add CommandPattern/CommandPattern.csproj
dotnet sln BehavioralPatternsPoC.sln add ChainOfResponsibilityPattern/ChainOfResponsibilityPattern.csproj
```
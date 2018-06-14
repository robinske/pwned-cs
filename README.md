# pwned-cs
Example .NET core app using the [PwnedPasswords.Client](https://github.com/andrewlock/PwnedPasswords) lib

## Running the program

Install the PwnedPasswords.Client NuGet package into your project using the [dotnet](https://www.microsoft.com/net/learn/get-started) CLI:

```
dotnet add package PwnedPasswords.Client --version 1.0.0
```

Clone this repo

```
git clone git@github.com:robinske/pwned-cs.git
cd pwned-cs
```

Run the project with `dotnet run` from the console to see the boolean result.

As Andrew outlines in the [detailed README](https://github.com/andrewlock/PwnedPasswords/blob/master/README.md), you can *also* use the library as part of your Identity Validator by adding it to your Identity builder.

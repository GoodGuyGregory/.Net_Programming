## C# Features

String interpolation techniques allow for more consise methods of Console Writing

```C#
// Variable Old_School Method:
var address_school = string.Format("\n334 S. Main Street., {0}. {1}, {2}", city, state, zip);

//  Here is easier approach
var address_Newschool = $"\n334 S. Main St, {City}, {State}, {Zip}";

decimal money - 85;
var MoneyOwned = $"Today: {DateTime.Now.ToShortDateString()}, Dollars owed: {money:C}";

Console.Writeline(address_Newschool);
Console.Writeline(MoneyOwned);
```

## C# Testing

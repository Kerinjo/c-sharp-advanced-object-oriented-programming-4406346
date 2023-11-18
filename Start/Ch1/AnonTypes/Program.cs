// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Creating and using Anonymous types

// TODO: Anonymous types can be declared using "new" and { }, similar to JS
var myobj = new {
    Name = "Konrad Marciniak",
    Age = 25,
    Adress = new {
        Street = "123 Main St",
        City = "Anywhere"
    }
};
// Compiler infers the type of each property
// Anonymous types also override the ToString method of the base Object class.
Console.WriteLine($"{myobj.Name}, {myobj.Adress.Street}");
Console.WriteLine($"{myobj}");

// Anonymous types are read-only and cannot be modified
// myobj.Name = "Jane Doe"; # will cause an error

// TODO: To change a value, use non-destructive mutation and "with" clause
var myobj2 = myobj with {Name = "Joe Marini"};
Console.WriteLine($"{myobj2}");

// TODO: You can check to see if an anonymous object contains a property
Console.WriteLine($"{myobj.GetType().GetProperty("Name") != null}");
Console.WriteLine($"{myobj.GetType().GetProperty("Job") != null}");
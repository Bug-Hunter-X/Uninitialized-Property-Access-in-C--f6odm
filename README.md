# Uninitialized Property Access in C#

This repository demonstrates a common coding error in C#: accessing a property before it's been initialized. This can lead to unexpected behavior, especially `NullReferenceException` if the property is of a reference type.

## The Bug

The `bug.cs` file contains a class with a property that is not initialized in the constructor.  The `MyMethod` attempts to use this property without first setting its value.  If the property were a reference type, this would cause a `NullReferenceException`. Even if it's a value type (like `int`), it might lead to unexpected values since it will have the default value of the type (0 for int).

## The Solution

The `bugSolution.cs` file shows the corrected code.  The property is now initialized in the constructor to eliminate potential errors.  Alternatively, you can include null checks to handle cases where the property might be null before first use.

## How to Reproduce

1. Clone this repository.
2. Open the solution in Visual Studio or your preferred C# IDE.
3. Run the `bug.cs` code. This will show that the uninitialized access can produce an error (or unexpected value).
4. Modify and run the `bugSolution.cs` code.  This corrected version will demonstrate how to avoid this issue.

This example highlights the importance of properly initializing properties in C# to prevent unexpected behavior and runtime errors.
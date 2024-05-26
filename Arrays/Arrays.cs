//Array always requires [] brackets. Each item has to share the same variable type.

string [] boxes = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

//The foreach loop accesses each item in an array, using a temporary variable (of the same type)

foreach (string item in boxes)
if (item.StartsWith("B"))
{
    Console.WriteLine($"Potential item {item} has been found.");
}